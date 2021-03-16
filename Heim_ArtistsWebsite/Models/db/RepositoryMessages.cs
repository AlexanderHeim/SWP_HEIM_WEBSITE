using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models.db
{
    public class RepositoryMessages : IRepositoryMessages
    {

        private string _connectionString = "server=localhost;database=db_blog;uid=root;pwd=1234";
        private MySqlConnection _connection = null;

        public void Open() {
            if (this._connection == null) {
                this._connection = new MySqlConnection(this._connectionString);
            }
            if (this._connection.State != System.Data.ConnectionState.Open) {
                this._connection.Open();
            }
        }

        public void Close()
        {
            if ((this._connection != null) && (this._connection.State == System.Data.ConnectionState.Open)) {
                this._connection.Close();
            }
        }

        public Message GetMessageById(uint messageId)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdSelect = this._connection.CreateCommand();
                cmdSelect.CommandText = "select * from messages where message_id = @messageId;";

                DbParameter paramId = cmdSelect.CreateParameter();
                paramId.ParameterName = "messageId";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = messageId;

                cmdSelect.Parameters.Add(paramId);
                using (DbDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Message
                        {
                            Sender = Convert.ToString(reader["username"]),
                            MessageText = Convert.ToString(reader["text"]),
                        };
                    }
                }
            }
            return null;
        }

        public List<Message> GetAllMessages()
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                List<Message> messages = new List<Message>();
                DbCommand cmdSelect = this._connection.CreateCommand();
                cmdSelect.CommandText = "select * from messages order by message_id";

                using (DbDataReader reader = cmdSelect.ExecuteReader()) {
                    while (reader.Read())
                    {

                        messages.Add(new Message
                        {
                            Sender = Convert.ToString(reader["username"]),
                            MessageText = Convert.ToString(reader["text"]),
                        });
                    }
                }
                return messages;
            }
            throw new Exception("Database: Couldn't get connection! Is it open?");
        }

        public bool Insert(Message message)
        {
            if (message == null)
            {
                return false;
            }

            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdInsert = this._connection.CreateCommand();
                cmdInsert.CommandText = "insert into messages values(null, @username, @message_text);";

                DbParameter paramMessageUsername = cmdInsert.CreateParameter();
                paramMessageUsername.ParameterName = "username";
                paramMessageUsername.DbType = System.Data.DbType.String;
                paramMessageUsername.Value = message.Sender;

                DbParameter paramMessageText = cmdInsert.CreateParameter();
                paramMessageText.ParameterName = "message_text";
                paramMessageText.DbType = System.Data.DbType.String;
                paramMessageText.Value = message.MessageText;

                cmdInsert.Parameters.Add(paramMessageUsername);
                cmdInsert.Parameters.Add(paramMessageText);

                return cmdInsert.ExecuteNonQuery() == 1;
            }
            return false;
        }

        public bool DeleteById(uint messageId)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdDelete = this._connection.CreateCommand();
                cmdDelete.CommandText = "delete from messages where message_id = @messageId;";

                DbParameter paramId = cmdDelete.CreateParameter();
                paramId.ParameterName = "messageId";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = messageId;

                cmdDelete.Parameters.Add(paramId);

                return cmdDelete.ExecuteNonQuery() == 1;
            }
            return false;
        }

        public bool UpdateById(uint messageId, Message newMessage)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdUpdate = this._connection.CreateCommand();
                cmdUpdate.CommandText = "update messages set username = @username, text = @message_text where message_id = @messageId;";

                DbParameter paramId = cmdUpdate.CreateParameter();
                paramId.ParameterName = "messageId";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = messageId;

                DbParameter paramMessageUsername = cmdUpdate.CreateParameter();
                paramMessageUsername.ParameterName = "username";
                paramMessageUsername.DbType = System.Data.DbType.String;
                paramMessageUsername.Value = newMessage.Sender;

                DbParameter paramMessageText = cmdUpdate.CreateParameter();
                paramMessageText.ParameterName = "message_text";
                paramMessageText.DbType = System.Data.DbType.String;
                paramMessageText.Value = newMessage.MessageText;

                cmdUpdate.Parameters.Add(paramMessageUsername);
                cmdUpdate.Parameters.Add(paramMessageText);
                cmdUpdate.Parameters.Add(paramId);

                return cmdUpdate.ExecuteNonQuery() == 1;
            }
            return false;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models.db
{
    public class RepositoryArticles : IRepositoryArticles
    {
        private string _connectionString = "server=localhost;database=db_blog;uid=root;pwd=1234";
        private MySqlConnection _connection = null;

        public void Open()
        {
            if (this._connection == null)
            {
                this._connection = new MySqlConnection(this._connectionString);
            }
            if (this._connection.State != System.Data.ConnectionState.Open)
            {
                this._connection.Open();
            }
        }

        public void Close()
        {
            if ((this._connection != null) && (this._connection.State == System.Data.ConnectionState.Open))
            {
                this._connection.Close();
            }
        }

        public Article GetArticleById(uint articleId)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdSelect = this._connection.CreateCommand();
                cmdSelect.CommandText = "select * from articles where article_id = @articleId;";

                DbParameter paramId = cmdSelect.CreateParameter();
                paramId.ParameterName = "articleId";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = articleId;
                cmdSelect.Parameters.Add(paramId);

                using (DbDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Article
                        {
                            Article_id = Convert.ToUInt32(reader["article_id"]),
                            Title = Convert.ToString(reader["title"]),
                            Html_text = Convert.ToString(reader["html_text"]),
                        };
                    }
                }
            }
            return null;
        }

        public List<Article> GetAllArticles()
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                List<Article> articles = new List<Article>();
                DbCommand cmdSelect = this._connection.CreateCommand();
                cmdSelect.CommandText = "select * from articles order by article_id desc";

                using (DbDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        articles.Add(new Article
                        {
                            Article_id = Convert.ToUInt32(reader["article_id"]),
                            Title = Convert.ToString(reader["title"]),
                            Html_text = Convert.ToString(reader["html_text"]),
                        });
                    }
                }
                return articles;
            }
            throw new Exception("Database: Couldn't get connection! Is it open?");
        }

        public bool Insert(Article article)
        {
            if (article == null)
            {
                return false;
            }

            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdInsert = this._connection.CreateCommand();
                cmdInsert.CommandText = "insert into articles values(null, @title, @html_text);";

                DbParameter paramArticleTitle = cmdInsert.CreateParameter();
                paramArticleTitle.ParameterName = "title";
                paramArticleTitle.DbType = System.Data.DbType.String;
                paramArticleTitle.Value = article.Title;

                DbParameter paramArticleHtmlText = cmdInsert.CreateParameter();
                paramArticleHtmlText.ParameterName = "html_text";
                paramArticleHtmlText.DbType = System.Data.DbType.String;
                paramArticleHtmlText.Value = article.Html_text;

                cmdInsert.Parameters.Add(paramArticleTitle);
                cmdInsert.Parameters.Add(paramArticleHtmlText);

                return cmdInsert.ExecuteNonQuery() == 1;
            }
            return false;
        }

        public bool DeleteById(uint articleId)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdDelete = this._connection.CreateCommand();
                cmdDelete.CommandText = "delete from articles where article_id = @article_id;";

                DbParameter paramId = cmdDelete.CreateParameter();
                paramId.ParameterName = "article_id";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = articleId;

                cmdDelete.Parameters.Add(paramId);

                return cmdDelete.ExecuteNonQuery() == 1;
            }
            return false;
        }

        public bool UpdateById(uint articleId, Article newArticle)
        {
            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                DbCommand cmdUpdate = this._connection.CreateCommand();
                cmdUpdate.CommandText = "update articles set title = @title, html_text = @html_text where article_id = @article_id;";

                DbParameter paramId = cmdUpdate.CreateParameter();
                paramId.ParameterName = "article_id";
                paramId.DbType = System.Data.DbType.UInt32;
                paramId.Value = articleId;

                DbParameter paramArticleTitle = cmdUpdate.CreateParameter();
                paramArticleTitle.ParameterName = "title";
                paramArticleTitle.DbType = System.Data.DbType.String;
                paramArticleTitle.Value = newArticle.Title;

                DbParameter paramArticleHtmlText = cmdUpdate.CreateParameter();
                paramArticleHtmlText.ParameterName = "html_text";
                paramArticleHtmlText.DbType = System.Data.DbType.String;
                paramArticleHtmlText.Value = newArticle.Html_text;

                cmdUpdate.Parameters.Add(paramArticleTitle);
                cmdUpdate.Parameters.Add(paramArticleHtmlText);
                cmdUpdate.Parameters.Add(paramId);

                return cmdUpdate.ExecuteNonQuery() == 1;
            }
            return false;
        }
    }

}

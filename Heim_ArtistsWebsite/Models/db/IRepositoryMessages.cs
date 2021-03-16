using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models.db
{
    interface IRepositoryMessages {

        void Open();
        void Close();

        Message GetMessageById(uint messageId);
        List<Message> GetAllMessages();
        bool Insert(Message message);
        bool DeleteById(uint messageId);
        bool UpdateById(uint messageId, Message newMessage);
    }
}

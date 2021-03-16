using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models.db
{
    interface IRepositoryArticles
    {

        void Open();
        void Close();

        Article GetArticleById(uint articleid);
        List<Article> GetAllArticles();
        bool Insert(Article article);
        bool DeleteById(uint articleId);
        bool UpdateById(uint articleId, Article newArticle);
    }
}

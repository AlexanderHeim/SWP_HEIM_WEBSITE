using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models
{
    public class Article
    {
        private uint article_id;
        private String title;
        private String html_text;

        public uint Article_id
        {
            get { return this.article_id; }
            set { this.article_id = value; }
        }

        public String Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public String Html_text
        {
            get { return this.html_text; }
            set { this.html_text = value; }
        }

        public Article() : this(0, "", "") { }
        public Article(uint article_id, String title, String html_text)
        {
            this.Article_id = article_id;
            this.Title = title;
            this.Html_text = html_text;
        }

    }
}

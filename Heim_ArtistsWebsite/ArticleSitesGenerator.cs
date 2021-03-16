using Heim_ArtistsWebsite.Models;
using Heim_ArtistsWebsite.Models.db;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite
{
    public class ArticleSitesGenerator
    {
        private static IRepositoryArticles rep = new RepositoryArticles();

        static string root_folder = @"Generated\\articles";
        static string files_to_delete = @"*ArticleSite*.cshtml";
        static string[] file_list = System.IO.Directory.GetFiles(root_folder, files_to_delete);

        static string article_site_template = System.IO.Directory.GetFiles(root_folder, @"TEMPLATE_Article.cshtml")[0];

        public static void deleteSites()
        {
            foreach (String f in file_list)
            {
                System.IO.File.Delete(f);
            }
        }

        public static void generateSites()
        {
            try
            {
                rep.Open();
                List<Article> articles = rep.GetAllArticles();
                String html = File.ReadAllText(article_site_template);
                String[] sites = new string[1 + articles.Count / 6];
                for(int i = 0; i < sites.Length; i++)
                {
                    sites[i] = html;
                }

                for(int i = 0; i < articles.Count; i++)
                {
                    string test = "-" + i % 6 + "->TITLE<-" + i % 6 + "-";
                    sites[i/6] = sites[i / 6].Replace("-" + i % 6 + "->TITLE<-" + i % 6 + "-", articles[i].Title);
                    sites[i / 6] = sites[i / 6].Replace("-" + i % 6 + "->HTML_TEXT<-" + i % 6 + "-", articles[i].Html_text);
                }

                for(int i = 0; i < sites.Length; i++)
                {
                    string file_path = root_folder + "\\ArticleSite" + i + ".cshtml";
                    File.WriteAllText(file_path, sites[i]);
                }

            } catch(DbException)
            {

            } finally
            {
                rep.Close();
            }
        }
    }
}

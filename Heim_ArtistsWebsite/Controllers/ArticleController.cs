using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Heim_ArtistsWebsite.Models;
using Heim_ArtistsWebsite.Models.db;
using Microsoft.AspNetCore.Mvc;

namespace Heim_ArtistsWebsite.Controllers
{
    public class ArticleController : Controller
    {
        IRepositoryArticles rep = new RepositoryArticles();

        [HttpGet]
        public IActionResult Articles()
        {
            try
            {
                rep.Open();
                List<Article> articles = rep.GetAllArticles();
                rep.Close();
                return View(articles);

            }
            catch (DbException)
            {
                rep.Close();
                return View("ResultMessage", new ResultMessage("Database-Error", "Couldn't get the articles!", "Sorry.."));
            }
            finally
            {
                rep.Close();
            }
        }

        [HttpGet]
        public IActionResult Article(uint id)
        {
            try
            {
                rep.Open();
                Article article = rep.GetArticleById(id);
                return View(article);
            } catch (DbException)
            {

            } finally
            {
                rep.Close();
            }
            return View("ResultMessage", new ResultMessage("No Articles found!", "WE ARE SORRY FOR THIS MESS", ":c"));
        }

        [HttpGet]
        public IActionResult NewArticle()
        {
            return View(new Article());
        }

        [HttpPost]
        public IActionResult NewArticle(String submit, Article article)
        {
            if(submit == null)
            {
                return View(article);
            }

            if (article == null)
            {
                return RedirectToAction("NewArticle");
            }

            ValidateArticle(article);

            if (ModelState.IsValid)
            {
                try
                {
                    rep.Open();
                    if (rep.Insert(article))
                    {
                        return View("ResultMessage", new ResultMessage("Article has been sent!", "Article saved!"));
                    }
                }
                catch (DbException)
                {
                    return View("ResultMessage", new ResultMessage("Database-Error", "Couldn't insert article into database!", "Try again!"));
                }
                finally
                {
                    rep.Close();
                }

                return RedirectToAction("index", "message");
            }
            return View(new Article());
        }

        private void ValidateArticle(Article article)
        {
            if (article == null) return;

            if ((article.Title == null) || (article.Title.Length <= 5))
            {
                ModelState.AddModelError(nameof(Models.Article.Title), "Please enter a valid titel.");
            }

            if ((article.Html_text == null) || (article.Html_text.Length <= 10))
            {
                ModelState.AddModelError(nameof(Models.Article.Html_text), "Please enter a valid text.!");
            }
        }
    }
}

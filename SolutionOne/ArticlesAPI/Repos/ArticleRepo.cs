using ArticlesAPI.Models;

namespace ArticlesAPI.Repos
{   public class ArticleRepo : List<Article>, IArticleRepo
    {  private readonly static List<Article> _articles = Populate();
        private static List<Article> Populate()
        {
            var articles = new List<Article>()
            {  new Article()
                {     Id=1,
                    Title="Wings of Fire",
                    WriterId=3,

                },
                new Article()
                {   Id=2,
                    Title="My Experiment with Truth",
                    WriterId=2,

                },
                 new Article()
                {
                    Id=3,
                    Title="Freedom: Azadi",
                    WriterId=1,

                }
            };
            return articles;
        }
        public int Delete(int id)
        {    var delArticle=_articles.FirstOrDefault(x => x.Id == id);
            if (delArticle != null)
            {   _articles.Remove(delArticle);
            }
            return  delArticle?.Id ?? 0;
        }

        public List<Article> GetAll()
        {    return _articles;
        }
        public Article GetById(int id)
        {     return _articles.FirstOrDefault(a => a.Id == id);
        }    } }

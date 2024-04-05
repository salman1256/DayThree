using ArticlesAPI.Models;
using System.ComponentModel;

namespace ArticlesAPI.Repos
{
    public interface IArticleRepo
    {
        List<Article> GetAll();
        Article GetById(int id);
        int Delete (int id);
    }
}

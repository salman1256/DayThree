using WriterAPI.Models;

namespace WriterAPI.Repos
{
    public interface IWriterRepo
    {
        List<Writer> GetAll();
        Writer Get(int id);
        Writer Post(Writer writer);
    }
}

using WriterAPI.Models;

namespace WriterAPI.Repos
{
    public class WriterRepo : List<Writer>, IWriterRepo
    {
        private readonly static List<Writer> _writers = Populate();

        private static List<Writer> Populate()
        {
            var writers = new List<Writer>()
            {
                new Writer()
                {
                    Id=1,
                    Name="Arundhati Roy"
                   
                },
                new Writer()
                {
                    Id=2,
                    Name="M.K. Gandhi"

                },
                 new Writer()
                {
                    Id=3,
                    Name="A.P.J. Kalam"

                }
            };
           return writers;
        }
               
        public Writer Get(int id)
        {
            return _writers.FirstOrDefault(w => w.Id == id);

        }

        public List<Writer> GetAll()
        {
           return _writers;
        }

        public Writer Post(Writer writer)
        {
           var maxId=_writers.Max(w => w.Id);
            writer.Id = ++maxId;
            _writers.Add(writer);
            return writer;

        }
    }
}

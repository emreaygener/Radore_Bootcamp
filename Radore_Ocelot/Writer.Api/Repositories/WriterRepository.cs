using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Repositories
{
    public class WriterRepository : IWriterRepository
    {
        public static List<Models.Writer> writers = populateWriters();
        public static List<Models.Writer> populateWriters()
        {
            return new List<Models.Writer>
            {
                new Models.Writer { Id = 1, name = "John Doe" },
                new Models.Writer { Id = 2, name = "Jane Doe" },
                new Models.Writer { Id = 3, name = "John Smith" }
            };
        }
        public Models.Writer Get(int id) => writers.FirstOrDefault(w => w.Id == id);
        

        public List<Models.Writer> GetAll() => writers;

        public Models.Writer Insert(Models.Writer writer)
        {
            writer.Id = writers.Max(w => w.Id) + 1;
            writers.Add(writer);
            return writer;
        }
    }
}

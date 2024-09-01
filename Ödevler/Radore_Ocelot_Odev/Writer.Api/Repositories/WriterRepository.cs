using Writer.Api.Data;
using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Repositories
{
    public class WriterRepository : IWriterRepository
    {
        private readonly ApplicationDbContext context;

        public WriterRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Models.Writer Get(int id) => context.Writers.FirstOrDefault(w => w.Id == id);
        

        public List<Models.Writer> GetAll() => context.Writers.ToList();

        public Models.Writer Insert(Models.Writer writer)
        {
            context.Writers.Add(writer);
            context.SaveChanges();
            return writer;
        }
    }
}

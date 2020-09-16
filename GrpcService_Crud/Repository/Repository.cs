using System.Linq;
using System.Threading.Tasks;

namespace GrpcService_Crud.Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Models.Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
        }

        public IQueryable<Models.Employee> Get()
        {
            return _dbContext.Employees.AsQueryable();
        }
    }
}
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService_Crud.Repository
{
    public interface IRepository
    {
        Task Add(Models.Employee employee);
        IQueryable<Models.Employee> Get();
    }
}
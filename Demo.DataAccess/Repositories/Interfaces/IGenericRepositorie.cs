using Demo.DataAccess.Models.EmployeeModule;
using Demo.DataAccess.Models.Shared;

namespace Demo.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepositorie<TEntity>  where TEntity : BaseEntity 
    {
        int Add(TEntity entity);
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        TEntity? GetById(int id);
        int Remove(TEntity entity);
        int Update(TEntity entity);
    }
}

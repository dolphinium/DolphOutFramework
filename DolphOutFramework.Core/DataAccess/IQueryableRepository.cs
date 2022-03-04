using DolphOutFramework.Core.Entities;
using System.Linq;

namespace DolphOutFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}

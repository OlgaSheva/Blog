using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface IAsyncEntityStorage
    {
        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        void RemoveRange(params object[] entities);

        void RemoveRange(IEnumerable<object> entities);
    }
}

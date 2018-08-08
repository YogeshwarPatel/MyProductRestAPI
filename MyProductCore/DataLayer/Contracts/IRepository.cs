using System.Threading.Tasks;

namespace MyProductCore.DataLayer.Contracts
{
    public interface IRepository
    {
        int CommitChanges();

        Task<int> CommitChangesAsync();
    }
}

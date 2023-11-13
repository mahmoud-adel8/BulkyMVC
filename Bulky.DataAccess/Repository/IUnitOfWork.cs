using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        public ICategoryRepository Category { get; }
        void Save();
    }
}

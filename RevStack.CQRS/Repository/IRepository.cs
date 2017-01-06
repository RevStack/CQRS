using System;
using System.Threading.Tasks;
using RevStack.CQRS.Domain;


namespace RevStack.CQRS.Repository
{
    public interface IRepository
    {
        T GetById<T>(Guid id) where T : AggregateBase;
        Task<T> GetByIdAsync<T>(Guid id) where T : AggregateBase;
        void Save<T>(T aggregate) where T : AggregateBase;
        Task SaveAsync<T>(T aggregate) where T : AggregateBase;
    }
}

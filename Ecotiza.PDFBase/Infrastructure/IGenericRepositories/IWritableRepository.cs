using System;
using System.Linq.Expressions;

namespace Ecotiza.PDFBase.Infrastructure.IGenericRepositories
{
    public interface IWritableRepository<T>
    {
        void Add(T item);
        void Update(T item);
        //void UpdateOnlyInclude(T objectToUpdate, params Expression<Func<T, object>>[] navigationProperties);
        void Remove(T item);
    }
}
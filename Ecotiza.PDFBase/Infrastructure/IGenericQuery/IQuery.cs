using System.Collections.Generic;

namespace Ecotiza.PDFBase.Infrastructure.IGenericQuery
{
    public interface IQuery<TEntity>
    {
        void Init();
        void Sort(string sort, string sortBy);
        void Paginate(int itemsToShow, int page);
        int TotalRecords();
        IEnumerable<TEntity> Execute();
    }
}
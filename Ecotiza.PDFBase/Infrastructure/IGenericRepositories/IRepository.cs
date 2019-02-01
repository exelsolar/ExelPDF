namespace Ecotiza.PDFBase.Infrastructure.IGenericRepositories
{
    public interface IRepository<T> : IReadableRepository<T>, IWritableRepository<T>
    {

    }
}
namespace crud_api.Repositories.Contracts;
public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll();
}
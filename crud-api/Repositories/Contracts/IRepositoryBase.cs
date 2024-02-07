using System.Linq.Expressions;

namespace crud_api.Repositories.Contracts;
public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    void Create(T entity);
    Task DeleteByCondition(Expression<Func<T, bool>> expression);
    void Update(T entity);
    IQueryable<T> RunSql(FormattableString sql);
}
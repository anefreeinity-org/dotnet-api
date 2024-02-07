using System.Linq.Expressions;
using crud_api.Extensions;
using crud_api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace crud_api.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T:class
{
    private readonly MalDbContext _db;
    public RepositoryBase(MalDbContext context)
    {
        _db = context;
    }

    public IQueryable<T> FindAll()
    {
        return _db.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return _db.Set<T>().Where(expression).AsNoTracking();
    }

    public void Create(T entity)
    {
        _db.Set<T>().Add(entity);
    }

    public async Task DeleteByCondition(Expression<Func<T, bool>> expression)
    {
        await _db.Set<T>().Where(expression).ExecuteDeleteAsync();
    }

    public void Update(T entity)
    {
        _db.Set<T>().Update(entity);
    }

    public IQueryable<T> RunSql(FormattableString sql)
    {
        return _db.Set<T>().FromSql(sql);
    }
}

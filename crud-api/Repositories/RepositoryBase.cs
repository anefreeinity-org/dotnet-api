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
}
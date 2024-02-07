using crud_api.Extensions;
using crud_api.Repositories.Contracts;

namespace crud_api.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly MalDbContext _db;
    private readonly Lazy<IMALRepository> _malRepo;

    public RepositoryManager(MalDbContext context)
    {
        _db = context;
        _malRepo = new Lazy<IMALRepository>(() => new MALRepository(_db));
    }

    public IMALRepository MalRepo => _malRepo.Value;

    public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
}
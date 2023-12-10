using crud_api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace crud_api.Repositories;

public class MALRepository : RepositoryBase<MAL>, IMALRepository
{
    public MALRepository(MalDbContext context) : base(context) {}

    public async Task<IEnumerable<MAL>> GetAllMAL()
    {
        return await FindAll().ToListAsync();
    }
}
using System.Runtime.CompilerServices;
using crud_api.Extensions;
using crud_api.Models.Entities;
using crud_api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace crud_api.Repositories;

public class MALRepository : RepositoryBase<MAL>, IMALRepository
{
    public MALRepository(MalDbContext context) : base(context) {}

    public async Task<IEnumerable<MAL>> GetAllMALRepo()
    {
        return await FindAll().ToListAsync();
    }

    public async Task<MAL> GetMALRepoById(int id)
    {
        var entity = await FindByCondition(x=>x.Id == id).FirstOrDefaultAsync();
        if(entity == null)
        {
            throw new Exception("Not found");
        }
        return entity;
    }

    public void AddMal(MAL mal)
    {
        Create(mal);
    }

    public async Task DeleteById(int id)
    {
        await DeleteByCondition(x=>x.Id == id);
    }

    public void UpdateMal(MAL entity)
    {
        Update(entity);
    }

    public async Task<IEnumerable<MAL>> RunSQLQuery(string query)
    {
        return await RunSql(FormattableStringFactory.Create(query)).ToListAsync();
    }
}

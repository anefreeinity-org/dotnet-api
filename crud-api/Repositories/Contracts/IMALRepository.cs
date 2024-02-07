using crud_api.Models.Entities;

namespace crud_api.Repositories.Contracts;

public interface IMALRepository : IRepositoryBase<MAL>
{
    Task<IEnumerable<MAL>> GetAllMALRepo();
    Task<MAL> GetMALRepoById(int id);
    void AddMal(MAL mal);
    Task DeleteById(int id);
    void UpdateMal(MAL entity);
    Task<IEnumerable<MAL>> RunSQLQuery(string query);
}
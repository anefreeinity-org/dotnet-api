namespace crud_api.Repositories.Contracts;

public interface IMALRepository : IRepositoryBase<MAL>
{
    Task<IEnumerable<MAL>> GetAllMAL();
}
using crud_api.Models.Dtos;

namespace crud_api.Services.Contracts;

public interface IMALService
{
    Task<IEnumerable<MALDtos>> GetAllMALService();
    Task<MALDtos> GetMalByIdService(int id);
    Task<int> AddMalService(MALDtos malDto);
    Task<int> DeleteByIdService(int id);
    Task<int> UpdateMalService(MALDtos malDto);
    Task<IEnumerable<MALDtos>> RunSQLQueryService(string query);
}
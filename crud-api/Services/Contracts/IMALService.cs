using crud_api.Models.Dtos;

namespace crud_api.Services.Contracts;

public interface IMALService
{
    Task<IEnumerable<MALDtos>> GetAllMALService();
}
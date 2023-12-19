using crud_api.Models.Dtos;
using crud_api.Models.Entities;
using crud_api.Repositories.Contracts;
using crud_api.Services.Contracts;

namespace crud_api.Services;

public class MALService : IMALService
{
    private readonly IRepositoryManager _repository;

    public MALService(IRepositoryManager repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MALDtos>> GetAllMALService()
    {
        IEnumerable<MAL> malList = await _repository.MalRepo.GetAllMALRepo();
        List<MALDtos> malListDto = new List<MALDtos>();
        
        foreach (var item in malList)
        {
            MALDtos newDto = new MALDtos()
            {
                Id = item.Id,
                Name = item.Name,
                Genres = item.Genres,
                Year = item.Year,
                Rank = GenerateRandom(1, 10),
            };

            malListDto.Add(newDto);
        }
        return await Task.FromResult(malListDto);
    }

    private int GenerateRandom(int min, int max)
    {  
        Random rnd = new Random();
        return rnd.Next(min, max);
    }
}

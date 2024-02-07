using crud_api.Extensions;
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

    public async Task<MALDtos> GetMalByIdService(int id)
    {
        MAL mal = await _repository.MalRepo.GetMALRepoById(id);
        MALDtos malDto = new MALDtos()
        {
            Id = mal.Id,
            Name = mal.Name,
            Genres = mal.Genres,
            Year = mal.Year,
            Rank = GenerateRandom(1, 10),
        };
        return await Task.FromResult(malDto);
    }

    public async Task<int> AddMalService(MALDtos malDto)
    {
        MAL mal = new MAL(){
            Id = malDto.Id??0,
            Name = malDto.Name,
            Genres = malDto.Genres,
            Year = malDto.Year,
        };

        _repository.MalRepo.AddMal(mal);
        await _repository.Save();
        return mal.Id;
    }

    public async Task<int> DeleteByIdService(int id)
    {
        await _repository.MalRepo.DeleteById(id);
        return id;
    }

    public async Task<int> UpdateMalService(MALDtos malDto)
    {
        MAL mal = new MAL(){
            Id = malDto.Id??0,
            Name = malDto.Name,
            Genres = malDto.Genres,
            Year = malDto.Year,
        };

        _repository.MalRepo.UpdateMal(mal);
        await _repository.Save();
        return mal.Id;
    }

    public async Task<IEnumerable<MALDtos>> RunSQLQueryService(string query)
    {
        IEnumerable<MAL> malList = await _repository.MalRepo.RunSQLQuery(query);
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

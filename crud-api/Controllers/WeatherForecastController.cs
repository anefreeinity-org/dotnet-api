using crud_api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace crud_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IRepositoryManager _repo;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepositoryManager repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpGet(Name = "demo")]
    public async Task<IEnumerable<MAL>> Get()
    {
        return await _repo.MalRepo.GetAllMAL();
    }
}

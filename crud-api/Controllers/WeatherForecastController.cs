using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly MalDbContext _db;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MalDbContext context)
    {
        _logger = logger;
        _db = context;
    }

    [HttpGet(Name = "demo")]
    public async Task<IEnumerable<MAL>> Get()
    {
        //return await _db.Set<MAL>().AsNoTracking().ToListAsync();
        return await _db.Mal.ToListAsync();
    }
}

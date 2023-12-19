using crud_api.Models.Dtos;
using crud_api.Models.Entities;
using crud_api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace crud_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MALController : ControllerBase
{
    private readonly IServiceManager _service;

    public MALController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<MALDtos>> GetAllMALController()
    {
        return await _service.MalService.GetAllMALService();
    }
}
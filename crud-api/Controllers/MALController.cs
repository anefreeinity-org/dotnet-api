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

    [HttpGet("malId")]
    public async Task<MALDtos> GetMALByIdController(int malId)
    {
        return await _service.MalService.GetMalByIdService(malId);
    }

    [HttpPost]
    public async Task<int?> Add([FromBody] MALDtos model)
    {
        return await _service.MalService.AddMalService(model);
    }

    [HttpDelete("malId")]
    public async Task<int?> Delete(int malId)
    {
        return await _service.MalService.DeleteByIdService(malId);
    }

    [HttpPut]
    public async Task<int?> Update([FromBody] MALDtos model)
    {
        return await _service.MalService.UpdateMalService(model);
    }

    [HttpPost]
    [Route("/[controller]/query")]
    public async Task<IEnumerable<MALDtos>> RunQuer([FromBody] string query)
    {
        return await _service.MalService.RunSQLQueryService(query);
    }
}

using crud_api.Repositories.Contracts;
using crud_api.Services.Contracts;

namespace crud_api.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IMALService> _malService;

    public IMALService MalService => _malService.Value;

    public ServiceManager(IRepositoryManager repository)
    {
        _malService = new Lazy<IMALService>(()=>new MALService(repository));
    }
}
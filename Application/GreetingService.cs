using Microsoft.Extensions.Configuration;

namespace Application;

public class GreetingService
{
    private readonly IConfiguration _configuration;
    
    public GreetingService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string Greet() => $"Hello, {_configuration["NAME_TO_GREET"] ?? throw new ArgumentNullException()}!";
}
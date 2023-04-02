using Microsoft.Extensions.Logging;

namespace Application;

public class Class1
{
    private readonly ILogger<Class1> _logger;

    public Class1(ILogger<Class1> logger)
    {
        _logger = logger;
    }
}
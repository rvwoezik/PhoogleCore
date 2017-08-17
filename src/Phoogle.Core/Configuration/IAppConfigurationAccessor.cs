using Microsoft.Extensions.Configuration;

namespace Phoogle.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

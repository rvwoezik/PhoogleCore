using System.Threading.Tasks;
using Phoogle.Sessions.Dto;

namespace Phoogle.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

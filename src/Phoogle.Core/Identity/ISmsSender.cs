using System.Threading.Tasks;

namespace Phoogle.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
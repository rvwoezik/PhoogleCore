using System.Threading.Tasks;
using Phoogle.Security.Recaptcha;

namespace Phoogle.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public async Task ValidateAsync(string captchaResponse)
        {
            
        }
    }
}

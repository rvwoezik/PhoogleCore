using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Phoogle.Authorization.Roles;
using Phoogle.Authorization.Users;
using Phoogle.MultiTenancy;

namespace Phoogle.Identity
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager, 
            IHttpContextAccessor contextAccessor,
            UserClaimsPrincipalFactory claimsFactory, 
            IOptions<IdentityOptions> optionsAccessor, 
            ILogger<SignInManager<User>> logger,
            IUnitOfWorkManager unitOfWorkManager,
            ISettingManager settingManager
            ) : base(
                userManager, 
                contextAccessor, 
                claimsFactory, 
                optionsAccessor, 
                logger,
                unitOfWorkManager,
                settingManager)
        {
        }
    }
}

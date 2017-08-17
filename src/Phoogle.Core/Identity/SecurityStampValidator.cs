using Abp.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Phoogle.Authorization.Roles;
using Phoogle.Authorization.Users;
using Phoogle.MultiTenancy;

namespace Phoogle.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}
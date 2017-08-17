using Abp.Domain.Services;

namespace Phoogle
{
    public abstract class PhoogleDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PhoogleDomainServiceBase()
        {
            LocalizationSourceName = PhoogleConsts.LocalizationSourceName;
        }
    }
}

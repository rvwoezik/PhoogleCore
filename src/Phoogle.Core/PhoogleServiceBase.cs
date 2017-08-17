using Abp;

namespace Phoogle
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="PhoogleDomainServiceBase"/>.
    /// For application services inherit PhoogleAppServiceBase.
    /// </summary>
    public abstract class PhoogleServiceBase : AbpServiceBase
    {
        protected PhoogleServiceBase()
        {
            LocalizationSourceName = PhoogleConsts.LocalizationSourceName;
        }
    }
}
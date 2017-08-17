using Abp.AspNetCore.Mvc.ViewComponents;

namespace Phoogle.Web.Public.Views
{
    public abstract class PhoogleViewComponent : AbpViewComponent
    {
        protected PhoogleViewComponent()
        {
            LocalizationSourceName = PhoogleConsts.LocalizationSourceName;
        }
    }
}
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Phoogle.Web.Public.Views
{
    public abstract class PhoogleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhoogleRazorPage()
        {
            LocalizationSourceName = PhoogleConsts.LocalizationSourceName;
        }
    }
}

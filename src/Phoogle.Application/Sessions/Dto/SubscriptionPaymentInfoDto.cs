using Abp.AutoMapper;
using Phoogle.MultiTenancy.Payments;

namespace Phoogle.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}
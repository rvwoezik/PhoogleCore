using System.ComponentModel.DataAnnotations;

namespace Phoogle.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
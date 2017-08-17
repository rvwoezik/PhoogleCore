using System.ComponentModel.DataAnnotations;
using Phoogle.Authorization.Users;

namespace Phoogle.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}
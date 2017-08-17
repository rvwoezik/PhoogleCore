using System.ComponentModel.DataAnnotations;

namespace Phoogle.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

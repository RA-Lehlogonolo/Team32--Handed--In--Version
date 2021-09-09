using System.ComponentModel.DataAnnotations;

namespace VillageBoard.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
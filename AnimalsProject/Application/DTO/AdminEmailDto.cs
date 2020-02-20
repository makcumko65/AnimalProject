using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class AdminEmailDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

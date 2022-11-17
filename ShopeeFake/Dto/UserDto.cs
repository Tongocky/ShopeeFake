using System.ComponentModel.DataAnnotations;

namespace ShopeeFake.Dto
{
    public class UserDto
    {
        public long UserId { get; set; }
        public long AppRoleId { get; set; }
        public string Address { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;

        public int Gender { get; set; }
        public string? Image { get; set; }
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        [Phone]
        public int? Phone { get; set; }

        public DateTime RegisterDate { get; set; }
        public bool Status { get; set; }
        public string? Token { get; set; }
    }
}

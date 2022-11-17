namespace ShopeeFake.Models
{
    public class AppRole
    {
        public AppRole()
        {
            Users = new HashSet<User>();
        }

        public long AppRoleId { get; set; }

        public string RoleName { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; } = null!;
    }
}
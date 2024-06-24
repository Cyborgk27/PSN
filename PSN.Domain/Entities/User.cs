using System.Collections;

namespace PSN.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Posts = [];
            Comments = [];
        }

        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

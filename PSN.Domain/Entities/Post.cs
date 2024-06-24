namespace PSN.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Post() 
        {
            Comments = [];
        }
        public int UserId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }

    }
}

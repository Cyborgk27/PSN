namespace PSN.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }

        public string Message { get; set; } = string.Empty;

        public virtual Post Post { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

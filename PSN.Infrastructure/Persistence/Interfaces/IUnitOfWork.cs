namespace PSN.Infrastructure.Persistence.Interfaces
{
    public interface IUnitOfWork
    {
        //Declaración o matrícula de nuestras interfaces a nivel de repo
        IUserRepository User { get; }
        IPostRepository Post { get; }
        ICommentRepository Comment { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}

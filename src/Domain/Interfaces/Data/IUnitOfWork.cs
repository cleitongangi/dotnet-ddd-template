namespace Domain.Interfaces.Data
{
    public interface IUnitOfWork
    {
        Task BeginTransactionAsync();
        Task CommitExternalAsync();
        Task RollbackAsync();
        Task SaveChangesAsync();
    }
}

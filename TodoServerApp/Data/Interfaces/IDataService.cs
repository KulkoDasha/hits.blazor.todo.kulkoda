namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<Taskitem>> GetTaskItemsAsync();
        Task SaveAsync(Taskitem item);
        Task<Taskitem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
    }
}

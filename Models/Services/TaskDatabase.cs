using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

public class TaskDatabase
{
    readonly SQLiteAsyncConnection _database;

    public TaskDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<TaskItem>().Wait();
    }

    public Task<List<TaskItem>> GetTasksAsync() => _database.Table<TaskItem>().ToListAsync();

    public Task<TaskItem> GetTaskAsync(int id) => _database.Table<TaskItem>().Where(i => i.ID == id).FirstOrDefaultAsync();

    public Task<int> SaveTaskAsync(TaskItem task) =>
        task.ID != 0 ? _database.UpdateAsync(task) : _database.InsertAsync(task);

    public Task<int> DeleteTaskAsync(TaskItem task) => _database.DeleteAsync(task);
}

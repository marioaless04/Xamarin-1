using SQLite;

public class TaskItem
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

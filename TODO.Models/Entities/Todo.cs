namespace TODO.Models.Entities;

public class Todo : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public long CreationTime { get; set; }
    public long DueDate { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
}
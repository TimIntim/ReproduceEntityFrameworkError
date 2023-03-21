namespace RemoveChildEntity.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    
    public Course(int id, string title)
    {
        Id = id;
        Title = title;
    }
}
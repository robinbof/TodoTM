namespace TodoTM.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; } // True = Done, False = Not Done
        public CategoryType Category { get; set; }
        public DateTime? Deadline { get; set; }
    }

    public enum CategoryType
    {
        None,
        Personal,
        Business
    }
}

namespace ToDoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        // Foreign key for the user who owns this TODO item
        public string UserId { get; set; }

        // Navigation property to represent the owner/user
        public AppUser User { get; set; }
    }

}

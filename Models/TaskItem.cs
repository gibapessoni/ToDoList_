using System.ComponentModel.DataAnnotations;

namespace ToDoList
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}


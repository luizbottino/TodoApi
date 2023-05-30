using System.Text.Json.Serialization;

namespace ToDoAPI.Entities
{

    public class TodoItem
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public Boolean? isComplete{ get; set; }

    }
}

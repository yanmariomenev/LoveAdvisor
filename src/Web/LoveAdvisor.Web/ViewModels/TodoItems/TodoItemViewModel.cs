namespace LoveAdvisor.Web.ViewModels.TodoItems
{
    using LoveAdvisor.Common.Mapping;
    using LoveAdvisor.Data.Models;

    public class TodoItemViewModel : IMapFrom<TodoItem>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}

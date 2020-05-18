namespace LoveAdvisor.Web.ViewModels.TodoItems
{
    using System.ComponentModel.DataAnnotations;

    using LoveAdvisor.Common.Mapping;
    using LoveAdvisor.Data.Models;

    public class TodoItemBindingModel : IMapTo<TodoItem>
    {
        [Required]
        public string Title { get; set; }
    }
}

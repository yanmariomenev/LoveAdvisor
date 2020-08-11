namespace LoveAdvisor.Web.Areas.Administration.Controllers
{
    using LoveAdvisor.Services.Data;
    using LoveAdvisor.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {

        public DashboardController()
        {
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}

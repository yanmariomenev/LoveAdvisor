namespace LoveAdvisor.Web.Areas.Administration.Controllers
{
    using LoveAdvisor.Common;
    using LoveAdvisor.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}

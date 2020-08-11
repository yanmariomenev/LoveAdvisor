namespace LoveAdvisor.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class TipsController : BaseController
    {
        public IActionResult Conversation()
        {
            return this.View();
        }

        public IActionResult Dating()
        {
            return this.View();
        }

        public IActionResult Tinder()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }
    }
}

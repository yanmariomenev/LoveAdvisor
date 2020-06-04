using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoveAdvisor.Web.Controllers
{
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
    }
}

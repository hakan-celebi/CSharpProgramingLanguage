using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_1_.Models
{
    [ViewComponent(Name = "Notification")]
    public class NotificationComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var temp = new ErrorViewModel();
            return View(temp);
        }
    }
}

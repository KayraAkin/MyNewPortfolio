﻿using Microsoft.AspNetCore.Mvc;

namespace MyNewPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

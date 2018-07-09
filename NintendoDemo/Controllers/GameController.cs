using NintendoDemo.Controllers.Base;
using NintendoDemo.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NintendoDemo.Controllers
{
    public class GameController : BaseController
    {
        public ActionResult Detail()
        {
            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                IGame model = _context.GetItem<IGame>(RenderingContext.Current.Rendering.DataSource);

                return View("~/Views/Game/Detail.cshtml", model);
            }

            return View(viewName: base.NoDataSourceViewPath, model: "Game Detail");
        }
    }
}
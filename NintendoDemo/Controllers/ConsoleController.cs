using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;
using Glass.Mapper.Sc;
using NintendoDemo.Controllers.Base;
using NintendoDemo.Models;
using NintendoDemo.Infrastructure.Attributes;

namespace NintendoDemo.Controllers
{
    public class ConsoleController : BaseController
    {
        public ConsoleController()
        {
            // TODO: adhere to good DI prinicples
        }

        public ActionResult Hero()
        {
            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                IProduct model = _context.GetItem<IProduct>(RenderingContext.Current.Rendering.DataSource);

                return View("~/Views/Console/Hero.cshtml", model);
            }

            return View(viewName: base.NoDataSourceViewPath, model: "Console Hero");
        }

        public ActionResult Detail()
        {
            var dsTemplate = RenderingContext.Current.Rendering.Item["Datasource Template"];

            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                IProduct model = _context.GetItem<IProduct>(RenderingContext.Current.Rendering.DataSource);

                return View("~/Views/Console/Detail.cshtml", model);
            }

            return View(viewName: base.NoDataSourceViewPath, model: "Console Detail");
        }

        public ActionResult Tile()
        {
            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                IProduct model = _context.GetItem<IProduct>(RenderingContext.Current.Rendering.DataSource);

                return View("~/Views/Console/Tile.cshtml", model);
            }

            return View(viewName: base.NoDataSourceViewPath, model: "Console Tile");
        }
    }
}
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NintendoDemo.Infrastructure.Attributes
{
    public class NullDataSourceAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource) && Sitecore.Context.PageMode.IsExperienceEditor)
            {
                filterContext.Result = new ViewResult {
                    ViewName = "~/Views/Shared/_NoDataSource.cshtml",
                    ViewData = filterContext.Controller.ViewData,
                    TempData = filterContext.Controller.TempData,
                };
            }
        }
    }
}
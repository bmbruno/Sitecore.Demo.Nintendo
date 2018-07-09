using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NintendoDemo.Controllers.Base
{
    public class BaseController : Controller
    {
        internal SitecoreContext _context;

        internal string NoDataSourceViewPath = "~/Views/Shared/_NoDataSource.cshtml";

        public BaseController()
        {
            _context = new SitecoreContext();
        }
    }
}
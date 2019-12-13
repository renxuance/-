using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Migrations.seeds
{
    public class ActionLinkCreator : Controller
    {
        //
        // GET: /ActionLinkCreator/

        private CourseManager.Models.CourseManagerEntities _context;

        public ActionResult Index(CourseManager.Models.CourseManagerEntities context)
        {
            return View();
        }

    }
}

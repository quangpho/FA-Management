using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FAM.BLL;
using Model;

namespace FAM.Presentation.Controllers
{
    public class ClassController : Controller
    {
        private readonly IService<ClassBatch> _service;
        public ClassController(IService<ClassBatch> service)
        {
            this._service = service;
        }
        // GET: Class
        public ActionResult Index()
        {
            var listClass = _service.GetAll();
            return View(listClass);
        }

    }
}
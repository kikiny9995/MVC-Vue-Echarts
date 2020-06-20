using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vue_Echarts.Bll.Service;

namespace Vue_Echarts.Controllers
{
    public class EchartsController : Controller
    {
        OutpatientService _outpatientService;

        public EchartsController()
        {
            _outpatientService = new OutpatientService();
        }

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public  ActionResult GetOutpatient()
        {
            var result = _outpatientService.GetOutpatients();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
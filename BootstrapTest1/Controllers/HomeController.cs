using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTest1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData(string msg)
        {
            List<P> list = new List<P>();
            list.Add(new P()
            {
                Name = "张三",
                Age = 18
            });
            list.Add(new P()
            {
                Name = "李四",
                Age = 20
            });
            list.Add(new P()
            {
                Name = "王五",
                Age = 30
            });
            return Json(list);
        }

    }
    public class P
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

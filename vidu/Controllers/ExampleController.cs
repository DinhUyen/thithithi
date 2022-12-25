using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidu.Models;

namespace vidu.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        Model1 _db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(BLOG blog)
        {
            // Lưu dữ liệu vào database
            //var  ob=db.BLOGs.
            _db.BLOGs.Add(blog);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult RenameProduct(string id , string name)
        {
            //https://localhost:44306/Example/RenameProduct?id=testID&name=testName
            string maId = id;
            string ten = name;
            return View();
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        #region test
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public string showmsg()
        //{
        //    return "hello bitches";
        //}
        public ViewResult ShowView()
        {
            ViewResult x = new ViewResult();
            x.ViewName = "view1";
            return x;
        }
        //public JsonResult showjson()
        //{
        //    var   res = new JsonResult(new {ID=1,name= "ahmed"});

        //    return res;
        //}
        //public IActionResult showmix(int id,int age)
        //{
        //     string s = "ahmed";
        //    if ((id & 1) == 1)
        //    {
        //        return Content($"{id} 3mk 3bnaser {age}");
        //    }
        //    else
        //    {
        //        return View("view1");
        //    }
        //}
        #endregion
        ProductSampleData sample = new ProductSampleData();

        //product/Details/1
        public IActionResult Details(int id)
        {
            var res =sample.GetById(id);
            //return View(sample);
            return View("showproducts", res);
        }
        //product/GetAll
        public IActionResult GetAll()
        {
            List<Product> productlist=sample.GetAll();
            return View("ShowListofproducts", productlist);
        }
    }
}

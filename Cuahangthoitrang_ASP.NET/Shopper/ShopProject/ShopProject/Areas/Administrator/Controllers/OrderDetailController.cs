using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopProject.Areas.Administrator.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: Administrator/OrderDetail
        Models.AdminContext dbOrder = new Models.AdminContext();
        [HandleError]
        public ActionResult Index(string name, string error)
        {
            if (Session["accname"] == null)
            {
                Session["accname"] = null;
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ViewBag.CusError = error;
                var model = dbOrder.OrderDetails.ToList();
                if (!string.IsNullOrEmpty(name))
                {
                    model = model.Where(p => p.orderID.Contains(name)).ToList();
                }
                return View(model);
            }
        }
    }
}
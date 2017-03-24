using namo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace namo.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrderById("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }
        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InserOrder(order);
            return View("Index");
        }
        public JsonResult TestJson()
        {
           
          //  var result = new Models.Order();
         //   result.CustName = "GSS";
         //   result.CustName = "瑞陽資訊";
            var result = new Models.Order()
            {
                CustId = "GSS",
                CustName = "瑞陽資訊"
            };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
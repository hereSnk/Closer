using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CloserRepository;
using Closer.Models;
namespace Closer.Controllers
{
    public class BaseController : Controller
    {
        public bool statusDataSaved = false;

        public string message = "";

        public ActionResult Welcome()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUPBuyer()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SignUPBuyer(BuyerInfo buyerInfo)
        {
            
            Buyer buyer = new Buyer();
            ViewBag.Status = buyer.RegisterBuyerData(buyerInfo);
            ViewBag.Message = "You are done with your SignUp";
            return View(buyerInfo);
        }
        //public JsonResult TrackLocation(string Location)
        //{
        //    return Json(new
        //        {
        //            result = "Ok"
        //        });

        //}
	}
}
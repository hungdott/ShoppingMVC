using AutoMapper;
using PMSShopping.Model.Models;
using PMSShopping.Services;
using PMSShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMSShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        ISlideService _slideService;
        public HomeController(ISlideService slideService)
        {
            this._slideService = slideService;
        }
        public ActionResult Index()
        {
            _slideService.Add(new Slide()
            {
                DisplayOrder = 1,
                Description = "asdfsdfsd",
                Image = "dsfgsdfsd",
                Name = "124123",
                Status = true,
                Url = "asdasd"

            });
            _slideService.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
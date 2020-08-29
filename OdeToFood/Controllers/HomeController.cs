using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturantData;
        private IErrorMessageData _errorMessage;
        private String _greeter;

        public HomeController(IResturantData resturantData
                             ,IGreeter greeter
                             ,IErrorMessageData errorMessage)
        {
            _resturantData = resturantData;
            _greeter = greeter.GetMessageOfDay();
            _errorMessage = errorMessage;
        }

        public IActionResult Index()
        {
  
            var model = new HomeIndexViewModel();
            model.Resturants = _resturantData.GetAll();
            model.CurrentMessage = _greeter;
            return View(model);           
        }

        public IActionResult Details(int id)
        {
            var model = _resturantData.Get(id);
            
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ResturantEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newResturant = new Resturant();
                newResturant.Name = model.Name;
                newResturant.Cuisine = model.Cuisine;

                newResturant = _resturantData.Add(newResturant);

                return RedirectToAction(nameof(Details), new { id = newResturant.Id });
            }
            else
            {
                return View();
            }
            
        }
    }
}

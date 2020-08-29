using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class HomeModel : PageModel
    {
        private IResturantData _resturant;

        public IEnumerable<Resturant> Resturants { get; set; }

        public HomeModel(IResturantData resturant)
        {
            _resturant = resturant;
        }
        public void OnGet()
        {
            
            Resturants = _resturant.GetAll();

        }
    }
}
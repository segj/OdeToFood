
using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }
        public Resturant Resturant { get; set; }
        public string CurrentMessage { get; set; }
    }
}

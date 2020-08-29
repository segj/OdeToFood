using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OdeToFood.Models;

namespace OdeToFood.Models
{
    public class Resturant
    {
        public int Id { get; set; }

        [Display(Name="Resturant name")]
        [Required, MaxLength(12)]
        public String Name{ get; set; }
        public CuisineType Cuisine { get; set; }
    }
    
}


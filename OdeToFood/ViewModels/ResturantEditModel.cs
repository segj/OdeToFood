using OdeToFood.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class ResturantEditModel
    {
        [Required, MaxLength(80)]
        public String Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}

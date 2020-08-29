using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;
using OdeToFood.Data;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Services
{
    public class OdeToFoodToFoodDbContext : IResturantData
    {
        private OdeToFoodDbContext _context;

        public OdeToFoodToFoodDbContext(OdeToFoodDbContext context)
        {
            _context = context;
        }
        public Resturant Add(Resturant newResturant)
        {
            _context.Resturants.Add(newResturant);
            _context.SaveChanges();
            return newResturant;
        }

        public Resturant Get(int id)
        {
            return _context.Resturants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _context.Resturants.OrderBy(r => r.Name); 
        }

        public Resturant Update(Resturant resturant)
        {
            _context.Attach(resturant).State = EntityState.Modified;
            _context.SaveChanges();
            return resturant;
        }
    }
}

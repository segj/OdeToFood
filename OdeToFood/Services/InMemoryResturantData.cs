using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{
 /*   public class InMemoryResturantData : IResturantData
    {
        public InMemoryResturantData()
        {
            _resturants = new List<Resturant>
            {
                new Resturant{Id = 1, Name="Svend" },
                new Resturant{Id = 2, Name="Bo" },
                new Resturant{Id = 3, Name="Ægge" }

            };
        }
        
        public IEnumerable<Resturant> GetAll()
        {
            return _resturants.OrderBy(r => r.Name);
        }

        public Resturant Get(int id)
        {
            return _resturants.FirstOrDefault(r => r.Id == id);
        }

        public Resturant Add(Resturant resturant)
        {
            resturant.Id = _resturants.Max(r => r.Id + 1);
            _resturants.Add(resturant);

            return resturant;
        }

        IEnumerable<Resturant> IResturantData.GetAll()
        {
            throw new NotImplementedException();
        }

        Resturant IResturantData.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Resturant> _resturants;
    }*/
}

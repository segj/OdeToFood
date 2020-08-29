﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant Get(int id);
        Resturant Add(Resturant newResturant);
        Resturant Update(Resturant resturant);
    }
}

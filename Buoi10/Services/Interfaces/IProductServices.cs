﻿using Buoi10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi10.Services.Interfaces
{
    public interface IProductServices
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ID);
        Product FindByID(int ID);
        IEnumerable<Product> GetAll();
    }
}

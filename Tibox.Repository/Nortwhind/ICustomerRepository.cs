﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;

namespace Tibox.Repository.Nortwhind
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer SearchByNames(string firstName, string lastName);
        Customer CustomerWithOrders(int id);
    }
}

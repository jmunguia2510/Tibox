﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibox.Models;
using Tibox.Repository;
using Tibox.Repository.Nortwhind;

namespace Tibox.UnitOfWork
{
    public class TiboxUnitOfWork : IUnitOfWork, IDisposable
    {

        public TiboxUnitOfWork()
        {
            Customers = new CustomerReporitory();
            Orders = new BaseRepository<Order>();
            OrderItems = new BaseRepository<OrderItem>();
            Products = new BaseRepository<Product>();
            Suppliers = new BaseRepository<Supplier>();
        }

        public ICustomerRepository Customers { get; private set; }

        public IRepository<Order> Orders { get; private set; }

        public IRepository<OrderItem> OrderItems { get; private set; }

        public IRepository<Product> Products { get; private set; }

        public IRepository<Supplier> Suppliers { get; private set; }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}

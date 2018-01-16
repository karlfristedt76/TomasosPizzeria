﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomasosPizzeria.Models
{
    public class EFMatrattRepository : IMatrattRepository
    {
        private TomasosContext context;

        public EFMatrattRepository(TomasosContext ctx) { context = ctx; }

        public IQueryable<Matratt> GetAllMatratter()
        {
            return context.Matratt;
        }

        public IQueryable<Kund> GetAllCustomers()
        {
            return context.Kund;
        }

        public IQueryable<Bestallning> GetAllOrders()
        {
            return context.Bestallning;
        }

        public IQueryable<Bestallning> GetOrdersById(int id)
        {
            var orders = context.Bestallning.Where(o => o.BestallningId == id);
            return context.Bestallning;
        }

        public IQueryable<Kund> GetCustomersById(int id)
        {
            var cust = context.Kund.Where(k => k.KundId == id);
            return cust;
        }
        public IQueryable<Matratt> GetMatratterById(int id)
        {
            var matratter = context.Matratt.Where(m => m.MatrattId == id);
            return matratter;
        }

        public void SaveOrder(Bestallning best)
        {
            context.Bestallning.Add(best);
            context.SaveChanges();
        }
    }
}

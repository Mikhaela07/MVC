using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.IServices
{
    public interface ITrading_operationsContext
    {
        DbSet<Checks> Checks { get; set; }
        DbSet<Goods> Goods { get; set; }
        DbSet<Organization> Organization { get; set; }
        int SaveChanges();
    }
}

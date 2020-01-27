using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServices;
using WebApplication1.DTOs;
using System.Data.SqlClient;

namespace WebApplication1.Services
{
    public class CheckService : ICheckService
    {
        private readonly ITrading_operationsContext context;
        public CheckService(ITrading_operationsContext _context)
        {
            context = _context;
        }
        public List<CheckDTO> GetCheck()
        {
            
            List<CheckDTO> checks = new List<CheckDTO>();
            foreach (var c in context.Checks.ToList()) { 
                    CheckDTO check = new CheckDTO()
                    {
                        Date = c.Date,
                        Price = c.Price,
                        Sale = c.Sale,
                       
                    };
                    checks.Add(check);
                }
            
           
            return checks;
        }

    }
}

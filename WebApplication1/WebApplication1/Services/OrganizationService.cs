using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly ITrading_operationsContext context;
        public OrganizationService(ITrading_operationsContext _context)
        {
            context = _context;
        }
        public List<OrganizationDTO> GetOrganization()
        {
            
            List<OrganizationDTO> Organization = new List<OrganizationDTO>();

            foreach (var o in context.Organization.ToList()) { 
                OrganizationDTO organization = new OrganizationDTO()
                    {
                        Name = o.Name,
                        Director = o.Director,
                        Address = o.Address,
                        Phone_number = o.PhoneNumber
                    };
                    Organization.Add(organization);
                }
            
           
            return Organization;
        }
    }
}

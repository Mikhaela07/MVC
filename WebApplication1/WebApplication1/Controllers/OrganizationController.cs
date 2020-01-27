using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication1.IServices;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class OrganizationController:Controller
    {
        private readonly IOrganizationService organizationService;
        private readonly IMapper mapper;
        public OrganizationController(IOrganizationService _organizationService, IMapper _mapper)
        {
            organizationService = _organizationService;
            mapper = _mapper;
        }
        public IActionResult Organization()
        {
            List<OrganizationModel> organization = new List<OrganizationModel>();
            foreach (var cl in organizationService.GetOrganization())
            {
                organization.Add(mapper.Map<OrganizationModel>(cl));
            }
            return View(organization);
        }
    }
}

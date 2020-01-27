using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CheckController : Controller
    {
        private readonly ICheckService checkService;
        private readonly IMapper mapper;
        public CheckController(ICheckService _checkService, IMapper _mapper)
        {
            checkService = _checkService;
            mapper = _mapper;
        }
        public IActionResult Check()
        {
            List<CheckModel> check = new List<CheckModel>();
            foreach (var cl in checkService.GetCheck())
            {
                check.Add(mapper.Map<CheckModel>(cl));
            }
            return View(check);
        }
    }
}
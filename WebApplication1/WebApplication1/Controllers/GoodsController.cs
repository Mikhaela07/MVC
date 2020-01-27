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
    public class GoodsController : Controller
    {

        private readonly IGoodsService goodsService;
        private readonly IMapper mapper;
        public GoodsController(IGoodsService _goodsService, IMapper _mapper)
        {
            goodsService = _goodsService;
            mapper = _mapper;
        }
        public IActionResult Goods()
        {
            List<GoodsModel> goods = new List<GoodsModel>();
            foreach (var cl in goodsService.GetGoods())
            {
                goods.Add(mapper.Map<GoodsModel>(cl));
            }
            return View(goods);
        }
    }
}
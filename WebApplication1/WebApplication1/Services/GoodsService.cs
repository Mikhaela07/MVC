using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class GoodsService: IGoodsService
    {
        private readonly ITrading_operationsContext context;
        public GoodsService(ITrading_operationsContext _context)
        {
            context = _context;
        }
        public List<GoodsDTO> GetGoods()
        {
            
            List<GoodsDTO> goods = new List<GoodsDTO>();
                foreach(var g in context.Goods.ToList()) { 
                    GoodsDTO good = new GoodsDTO()
                    {
                        Goods = g.Goods1,
                        Unit = g.Unit,
                        Quantity = g.Quantity,
                        Description = g.Description
                    };
                    goods.Add(good);
                }
            
            
            return goods;
        }


    }
}

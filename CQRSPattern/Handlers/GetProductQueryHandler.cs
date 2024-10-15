using CQRSDesingPattern.CQRSPattern.Results;
using CQRSDesingPattern.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CQRSDesingPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID=x.ProductId,
                Name=x.Name,
                Stock=x.Stock,
                Price=x.Price,
                Description=x.Description,
            }).ToList();
            return values;
        }
    }
}

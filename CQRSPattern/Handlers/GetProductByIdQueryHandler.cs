using CQRSDesingPattern.CQRSPattern.Queries;
using CQRSDesingPattern.CQRSPattern.Results;
using CQRSDesingPattern.DAL;
using System.Linq;

namespace CQRSDesingPattern.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIDQuery query)
        {
            var values=_context.Set<Product>().Find(query.Id);
            var valeu = new GetProductByIdQueryResult()
            {
                ProductId = values.ProductId,
                 Name=values.Name,
                 Price=values.Price,
                 Stock=values.Stock,
                 Description=values.Description,
            };
            return valeu;
        }
    }
}

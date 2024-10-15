using CQRSDesingPattern.CQRSPattern.Commands;
using CQRSDesingPattern.CQRSPattern.Queries;
using CQRSDesingPattern.CQRSPattern.Results;
using CQRSDesingPattern.DAL;
using Newtonsoft.Json.Linq;

namespace CQRSDesingPattern.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery command)
        {
            var values = _context.Products.Find(command.Id);
            return new GetProductUpdateQueryResult
            {
                 Description=values.Description,
                 Name=values.Name,
                 Price=values.Price,
                 ProductId=values.ProductId,
                 Stock = values.Stock
            };
        }
    }
}

using CQRSDesingPattern.CQRSPattern.Commands;
using CQRSDesingPattern.DAL;

namespace CQRSDesingPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.Id);
            values.ProductId = command.Id;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Description = command.Description;
            values.Status = true;
            _context.SaveChanges();
        }

    }
}

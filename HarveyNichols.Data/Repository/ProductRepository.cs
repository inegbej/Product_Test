using HarveyNichols.Data.Entities;

namespace HarveyNichols.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly HarveyNicholsContext _context;

        public ProductRepository(HarveyNicholsContext context)
        {
            _context = context;
        }

        public void Add(Products newProducts)
        {
            _context.Product.Add(newProducts);
            _context.SaveChanges();
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace HarveyNichols.Data.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public string Colour { get; set; }
        public string Sku { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechStoreInventory.Models
{
    public class Products
    {
        public Guid Id { get; set; }

        public required string Product { get; set; }
        public int Amount { get; set; }
        public string? Type { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal? Price { get; set; }
    }
}

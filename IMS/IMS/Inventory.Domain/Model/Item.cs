using Inventory.Domain.Seed;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Model
{
    public class Item : BaseAuditModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasurement { get; set; }

        public Item(Item item)
        {
            Name = item.Name;
            SerialNumber = item.SerialNumber;
            Category = item.Category;
            Description = item.Description;
            UnitOfMeasurement = item.UnitOfMeasurement;
        }

        public Item()
        {
        }
    }
}

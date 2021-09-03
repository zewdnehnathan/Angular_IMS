using Inventory.Domain.Model;
using Inventory.Domain.Seed;

namespace Inventory.Domain.Entities
{
    public class ItemEntity : BaseEntity<Item>
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasurement { get; set; }

        public ItemEntity(Item item)
        {
            Name = item.Name;
            SerialNumber = item.SerialNumber;
            Category = item.Category;
            Description = item.Description;
            UnitOfMeasurement = item.UnitOfMeasurement;
        }

        public override Item MapToModel()
        {
            Item item = new Item();
            item.Name = Name;
            item.SerialNumber = SerialNumber;
            item.Category = Category;
            item.Description = Description;
            item.UnitOfMeasurement = UnitOfMeasurement;
            return item;
        }

        public override Item MapToModel(Item t)
        {
            Item item = new Item();
            item.Id = t.Id;
            item.Name = t.Name;
            item.SerialNumber = t.SerialNumber;
            item.Category = t.Category;
            item.Description = t.Description;
            item.UnitOfMeasurement = t.UnitOfMeasurement;

            return item;
        }
    }
}

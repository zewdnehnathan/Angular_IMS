using Inventory.Domain.Seed;

namespace Inventory.Application.Dtos
{
    public class RequestItemDto 
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

       

    }
}

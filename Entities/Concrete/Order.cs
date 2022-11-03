using Core.Entities;

namespace Entities.Concrete
{
    public class Order : Base, IEntity
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public decimal TotalPrice { get; set; }

    }

}

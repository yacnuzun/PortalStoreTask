using Core.Entities;

namespace Entities.Concrete
{
    public class OrderItem : Base, IEntity
    {
        public int SkuId { get; set; }
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

    }

}

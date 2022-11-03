using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderItemManager : IOrderItemService
    {
        IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public IResult Add(OrderItem orderItem)
        {
            _orderItemDal.Add(orderItem);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _orderItemDal.Delete(new OrderItem { Id = id });
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<OrderItem> Get(int id)
        {
            var result = _orderItemDal.Get(or => or.Id == id);
            return new SuccessDataResult<OrderItem>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<OrderItem>> GetAll()
        {
            return new SuccessDataResult<List<OrderItem>>(_orderItemDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(OrderItem orderItem)
        {
            _orderItemDal.Update(orderItem);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}

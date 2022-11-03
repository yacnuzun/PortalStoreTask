using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order orderItem)
        {
            _orderDal.Add(orderItem);
            return new SuccessResult("Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _orderDal.Delete(new Order { Id = id });
            if (result)
                return new SuccessResult("Silindi.");
            return new ErrorResult("Bir şey oldu");

        }

        public IDataResult<Order> Get(int id)
        {
            var result = _orderDal.Get(o => o.Id == id);
            return new SuccessDataResult<Order>(result, "Listelendi.");
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), "Listelendi.");
        }


        public IResult Update(Order orderItem)
        {
            _orderDal.Update(orderItem);
            return new SuccessResult("Güncellendi.");
        }
    }
}

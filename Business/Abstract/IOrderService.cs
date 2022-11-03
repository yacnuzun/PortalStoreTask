using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> Get(int id);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(int id);

    }
}

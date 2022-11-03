using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        IDataResult<List<OrderItem>> GetAll();
        IDataResult<OrderItem> Get(int id);
        IResult Add(OrderItem orderItem);
        IResult Update(OrderItem orderItem);
        IResult Delete(int id);

    }
}

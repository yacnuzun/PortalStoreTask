using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int id);
        public Task<IResult> Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(int id);

    }
}

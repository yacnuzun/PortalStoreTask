using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _customerDal.Delete(new Customer { Id = id });
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<Customer> Get(int id)
        {
            var result = _customerDal.Get(cu => cu.Id == id);
            return new SuccessDataResult<Customer>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}

using Business.Abstract;
using Core.Utilities.Result;
using Core.Utilities.SoapService.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IIdentifyCheckService _ıdentifyCheckService;

        public CustomerManager(ICustomerDal customerDal, IIdentifyCheckService ıdentifyCheckService)
        {
            _customerDal = customerDal;
            _ıdentifyCheckService = ıdentifyCheckService;
        }

        public async Task<IResult> Add(Customer customer)
        {
            var check = await _ıdentifyCheckService.IsIdentifyCheck(customer.TCID, customer.FirstName, customer.LastName, customer.BirthDate);
            
            if (check==true)
            {
                _customerDal.Add(customer);
                return new SuccessResult("Eklendi.");
            }
            return new ErrorResult("Bir Hata oluştu.");
        }

        public IResult Delete(int id)
        {

            var result = _customerDal.Delete(new Customer { Id = id });
            if (result)
                return new SuccessResult("Silindi.");
            return new ErrorResult("Bir şey oldu.");

        }

        public IDataResult<Customer> Get(int id)
        {
            var result = _customerDal.Get(cu => cu.Id == id);
            return new SuccessDataResult<Customer>(result, "Listelendi.");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), "Listelendi.");
        }


        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("Güncellendi.");
        }
    }
}

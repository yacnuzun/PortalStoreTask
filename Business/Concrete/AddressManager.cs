using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _addressDal.Delete(new Address { Id = id });
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<Address> Get(int id)
        {
            var result = _addressDal.Get(a => a.Id == id);
            return new SuccessDataResult<Address>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}

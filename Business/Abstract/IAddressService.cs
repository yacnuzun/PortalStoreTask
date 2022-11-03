using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();
        IDataResult<Address> Get(int id);
        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(int id);

    }
}

using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int id);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(int id);

    }
}

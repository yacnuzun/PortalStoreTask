using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categeryDal)
        {
            _categoryDal = categeryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _categoryDal.Delete(new Category { Id = id });
            if (result)
                return new SuccessResult("Silindi.");
            return new ErrorResult("Bir şey oldu");

        }

        public IDataResult<Category> Get(int id)
        {
            var result = _categoryDal.Get(c => c.Id == id);
            return new SuccessDataResult<Category>(result, "Listelendi.");
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), "Listelendi.");
        }


        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult("Güncellendi.");
        }
    }
}

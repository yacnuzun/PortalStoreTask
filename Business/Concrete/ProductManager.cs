using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var result = _productDal.Delete(new Product { Id = id });
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<Product> Get(int id)
        {
            var result = _productDal.Get(p => p.Id == id);
            return new SuccessDataResult<Product>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}

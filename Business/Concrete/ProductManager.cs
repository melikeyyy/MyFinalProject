using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _prooductDal;

        public ProductManager(IProductDal prooductDal)
        {
            _prooductDal = prooductDal;
        }

        public List<Product> GetAll()
        {
            return _prooductDal.GetAll();
        }
    }
}

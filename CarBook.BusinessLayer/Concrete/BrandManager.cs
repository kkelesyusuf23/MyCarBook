using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TDelete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public Brand TGetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public List<Brand> TGetListAll()
        {
            return _brandDal.GetListAll();
        }

        public void TInsert(Brand entity)
        {
            _brandDal.Insert(entity);   
        }

        public void TUpdate(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}

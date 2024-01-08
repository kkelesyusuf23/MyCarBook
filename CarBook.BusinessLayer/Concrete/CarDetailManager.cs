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
    public class CarDetailManager : ICarDetailService
    {
        private readonly ICarDetailDal _carDetailDal;

        public CarDetailManager(ICarDetailDal carDetailDal)
        {
            _carDetailDal = carDetailDal;
        }

        public void TDelete(CarDetail entity)
        {
            _carDetailDal.Delete(entity);
        }

        public CarDetail TGetById(int id)
        {
            return _carDetailDal.GetById(id);
        }

        public CarDetail TGetCarDetailByCarId(int id)
        {
            return _carDetailDal.GetCarDetailByCarId(id);
        }

        public CarDetail TGetCarDetailWithAuthor(int id)
        {
            return _carDetailDal.GetCarDetailWithAuthor(id);
        }

        public List<CarDetail> TGetListAll()
        {
            return _carDetailDal.GetListAll();
        }

        public void TInsert(CarDetail entity)
        {
            _carDetailDal.Insert(entity);
        }

        public void TUpdate(CarDetail entity)
        {
            _carDetailDal.Update(entity);
        }
    }
}

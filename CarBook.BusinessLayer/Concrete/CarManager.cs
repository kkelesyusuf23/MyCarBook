using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TDelete(Car entity)
        {
            _carDal.Delete(entity);
        }

		public List<Car> TGetAllCarWithBrands()
		{
			return _carDal.GetAllCarWithBrands();
		}

		public Car TGetById(int id)
        {
            if(id != null)
            {
                return _carDal.GetById(id);
            }
            return _carDal.GetById(0);//araba bulunamadı
        }

        public List<Car> TGetListAll()
        {
            //bu işlemi yapmaya yetkiliyse
            return _carDal.GetListAll();
        }

        public void TInsert(Car entity)
        {
            if(entity.Year>=2010 && entity.Prices.Count > 0 && entity.km <= 500000)
            {
                _carDal.Insert(entity);
            }
            //hata mesajı-->fluent validation
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}

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
    public class CarRantManager : ICarRantService
    {
        private readonly ICarRantDal _carRantDal;

        public CarRantManager(ICarRantDal carRantDal)
        {
            _carRantDal = carRantDal;
        }

        public void TDelete(CarRant entity)
        {
            _carRantDal.Delete(entity);
        }

        public CarRant TGetById(int id)
        {
            return _carRantDal.GetById(id);
        }

        public List<CarRant> TGetListAll()
        {
            return _carRantDal.GetListAll();
        }

        public void TInsert(CarRant entity)
        {
            _carRantDal.Insert(entity);
        }

        public void TUpdate(CarRant entity)
        {
            _carRantDal.Update(entity);
        }
    }
}

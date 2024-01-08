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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetFirst3Service()
        {
            return _serviceDal.GetFirst3Service();
        }

        public List<Service> TGetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}

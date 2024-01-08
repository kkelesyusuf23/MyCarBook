using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public List<Service> GetFirst3Service()
        {
            var context = new CarBookContext();
            var values = context.Services.Take(3).ToList();
            return values;
        }
    }
}

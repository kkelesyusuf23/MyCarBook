using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.EntityFramework
{
	public class EfCarDal : GenericRepository<Car>, ICarDal
	{
		public List<Car> GetAllCarWithBrands()
		{
			var context = new CarBookContext();
			var values = context.Cars.Include(x => x.Brand).Include(y => y.CarCategory).Include(z => z.CarStatus).Include(a => a.Prices).ToList();
			return values;
		}
	}
}

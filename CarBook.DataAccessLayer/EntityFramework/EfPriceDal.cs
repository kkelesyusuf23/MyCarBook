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
    public class EfPriceDal : GenericRepository<Price>, IPriceDal
    {
        public List<Price> GetPricesWithCars()
        {
            var context = new CarBookContext();
            var values = context.Prices.Include(x => x.Car).ThenInclude(y => y.Brand).ToList();
            return values;
        }
    }
}

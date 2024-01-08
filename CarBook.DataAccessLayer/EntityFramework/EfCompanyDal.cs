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
	public class EfCompanyDal : GenericRepository<Company>, ICompanyDal
	{
		public Company GetCompanyforCarCompany()
		{
			var context = new CarBookContext();
			var value = context.Companies.Take(1).ToList();
			return value[0];
		}
		public Company GetCompanyforOurHistory()
		{
			var context = new CarBookContext();
			var latestCompany = context.Companies.OrderByDescending(c => c.CompanyID).FirstOrDefault();
			return latestCompany;
		}
	}
}

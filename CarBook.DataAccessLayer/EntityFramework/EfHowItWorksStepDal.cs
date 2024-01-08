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
	public class EfHowItWorksStepDal : GenericRepository<HowItWorksStep>, IHowItWorksStepDal
	{
		public List<HowItWorksStep> GetFirst5Steps()
		{
			var context = new CarBookContext();
			var values = context.HowItWorksSteps.Take(5).ToList();
			return values;
		}
	}
}

using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.Abstract
{
	public interface ICompanyService:IGenericService<Company>
	{
		public Company GetCompanyforCarCompany();
		public Company GetCompanyforOurHistory();
	}
}

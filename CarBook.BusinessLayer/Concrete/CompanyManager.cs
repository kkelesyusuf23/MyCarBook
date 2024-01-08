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
	public class CompanyManager:ICompanyService
	{
		private readonly ICompanyDal _companyDal;

		public CompanyManager(ICompanyDal companyDal)
		{
			_companyDal = companyDal;
		}

		public Company GetCompanyforCarCompany()
		{
			return _companyDal.GetCompanyforCarCompany();
		}

		public Company GetCompanyforOurHistory()
		{
			return _companyDal.GetCompanyforOurHistory();
		}

		public void TDelete(Company entity)
		{
			_companyDal.Delete(entity);
		}

		public Company TGetById(int id)
		{
			return _companyDal.GetById(id);
		}

		public List<Company> TGetListAll()
		{
			return _companyDal.GetListAll();
		}

		public void TInsert(Company entity)
		{
			_companyDal.Insert(entity);
		}

		public void TUpdate(Company entity)
		{
			_companyDal.Update(entity);
		}
	}
}

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
	public class ContactInfoManager:IContactInfoService
	{
		private readonly IContactInfoDal _contactInfoDal;

		public ContactInfoManager(IContactInfoDal contactInfoDal)
		{
			_contactInfoDal = contactInfoDal;
		}

		public void TDelete(ContactInfo entity)
		{
			_contactInfoDal.Delete(entity);
		}

		public ContactInfo TGetById(int id)
		{
			return _contactInfoDal.GetById(id);
		}

		public List<ContactInfo> TGetListAll()
		{
			return _contactInfoDal.GetListAll();
		}

		public void TInsert(ContactInfo entity)
		{
			_contactInfoDal.Insert(entity);
		}

		public void TUpdate(ContactInfo entity)
		{
			_contactInfoDal.Update(entity);
		}
	}
}

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
    public class HowItWorksStepManager : IHowItWorksStepService
    {
        private readonly IHowItWorksStepDal _howItWorksStepDal;

        public HowItWorksStepManager(IHowItWorksStepDal howItWorksStepDal)
        {
            _howItWorksStepDal = howItWorksStepDal;
        }

        public void TDelete(HowItWorksStep entity)
        {
            _howItWorksStepDal.Delete(entity);
        }

        public HowItWorksStep TGetById(int id)
        {
            return _howItWorksStepDal.GetById(id);
        }

		public List<HowItWorksStep> TGetFirst5Steps()
		{
			return _howItWorksStepDal.GetFirst5Steps();
		}

		public List<HowItWorksStep> TGetListAll()
        {
            return _howItWorksStepDal.GetListAll();
        }

        public void TInsert(HowItWorksStep entity)
        {
            _howItWorksStepDal.Insert(entity);
        }

        public void TUpdate(HowItWorksStep entity)
        {
            _howItWorksStepDal.Update(entity);
        }
    }
}

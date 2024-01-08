using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IHowItWorksStepService:IGenericService<HowItWorksStep>
    {
		List<HowItWorksStep> TGetFirst5Steps();
	}
}

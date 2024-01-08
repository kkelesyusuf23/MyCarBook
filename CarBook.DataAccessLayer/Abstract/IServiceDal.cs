using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IServiceDal:IGenericDal<Service>
    {
        List<Service> GetFirst3Service();
    }
}

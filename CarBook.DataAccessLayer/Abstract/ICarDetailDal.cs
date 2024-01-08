using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ICarDetailDal:IGenericDal<CarDetail>
    {
        CarDetail GetCarDetailByCarId(int id);
        CarDetail GetCarDetailWithAuthor(int id);
    }
}

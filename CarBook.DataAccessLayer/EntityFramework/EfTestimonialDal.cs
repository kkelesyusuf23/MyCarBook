using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
    }
}

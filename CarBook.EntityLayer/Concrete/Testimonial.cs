using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}

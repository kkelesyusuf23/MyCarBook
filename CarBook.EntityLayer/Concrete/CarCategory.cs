using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class CarCategory
    {
        public int CarCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public List<Car> Cars { get; set; }
    }
}

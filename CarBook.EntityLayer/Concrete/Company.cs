using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
	public class Company
	{
        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ImageURL { get; set; }
    }
}

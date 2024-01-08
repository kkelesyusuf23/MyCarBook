using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class CarRant
    {
        public int CarRantID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int DayNumber { get; set; }
        public int TotalPrice { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
	public class AppUser:IdentityUser<int>
	{
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public List<CarDetail> CarDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
	public class Contact
	{
		public int ContactID { get; set; }
		public string NameSurname { get; set; }
		public string Subject { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
	}
}

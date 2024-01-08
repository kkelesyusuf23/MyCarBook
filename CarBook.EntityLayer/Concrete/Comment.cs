using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; } 
        public string Description { get; set; } 
        public DateTime CreatedTime { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }

        public string? Name { get; set; } 

        public string? Description { get; set; } 

        public bool IsActive { get; set; }

        // Navigation Property
        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}

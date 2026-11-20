using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore.Models
{
    internal class Book
    {
       
            public int BookId { get; set; }

            public string? Title { get; set; } 

            public string? ISBN { get; set; } 

            public decimal Price { get; set; }

            public int NumberOfPages { get; set; }

            public int PublishedYear { get; set; }

            public bool IsInStock { get; set; }

            // Foreign Keys
            public int AuthorId { get; set; }

            public int CategoryId { get; set; }

            // Navigation Properties
            public Author? Author { get; set; } 

            public Category? Category { get; set; } 
        
    
    }
}

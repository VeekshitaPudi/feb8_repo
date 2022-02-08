using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Account
    {
        public string UserId { get; set; }  

        public string BookId { get; set; }  

        public int NoOfBooksAvailable { get; set; } 

        public int NoOfBooksBorrowed { get; set; }

        public int NoOfBooksReturnedBefore { get; set; }
        
        public int NoOfBooksReturnedAfter { get; set; } 
    }
}

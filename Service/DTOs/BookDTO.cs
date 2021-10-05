using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTOs
{
    public class BookDTO:BaseDTO
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberOfPage { get; set; }
    }
}

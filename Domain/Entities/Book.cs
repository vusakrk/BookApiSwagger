using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberOfPage { get; set; }
    }
}

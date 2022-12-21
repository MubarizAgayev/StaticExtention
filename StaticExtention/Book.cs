using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtention
{
    internal class Book
    {
        public string Name { get; set; }
        public static int Count { get; set; } = 0;

        public Book() 
        {
            Count++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    abstract class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Trophies { get; set; }
        public abstract void ShowProgram();
    }
}

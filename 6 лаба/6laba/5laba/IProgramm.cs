using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    interface IProgramm
    {
        Author Author { get; set; }
        int Duration { get; set; }
        int Rating { get; set; }
    }
}

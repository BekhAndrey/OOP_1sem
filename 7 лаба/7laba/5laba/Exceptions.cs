using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    public class RatingException : Exception
    {

        public RatingException(string message)
       : base(message)
        {

        }
    }
    public class TotalTimeException : Exception
    {
        public TotalTimeException(string message)
     : base(message)
        {

        }
    }
    public class ArrayIsFull : Exception
    {
        public ArrayIsFull(string message)
       : base(message)
        {
        }
    }
    public class ArrayIsEmpty : Exception
    {
        public ArrayIsEmpty(string message)
       : base(message)
        {
        }
    }
    public class ElementDoesNotExist : Exception
    {
        public ElementDoesNotExist(string message)
       : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Box
{
   public class BoxData<T>
    {
       public T Value {get; set;}

       public BoxData(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"Box contains : {Value}";
        }
    }
}
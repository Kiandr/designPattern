using System;
using System.Collections.Generic;

namespace StructuralDesignPattern.Adaptor.ExampleA
{
    public class Adaptor
    {
        internal virtual List<int> ConvertArrayToList(int[] array)
        {
            List<int> vs = new List<int>();
            foreach (var item in array) {
                vs.Add(item);
            }
            return vs;
        }
    }
}

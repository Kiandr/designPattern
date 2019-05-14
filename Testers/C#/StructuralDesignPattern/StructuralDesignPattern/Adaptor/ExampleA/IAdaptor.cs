using System;
using System.Collections.Generic;

namespace StructuralDesignPattern.Adaptor.ExampleA
{
    internal interface IAdaptor
    {
        List<int> ConvertArrayToList(int [] array);
    }
}

using System;
using StructuralDesignPattern.Adaptor;

namespace StructuralDesignPattern.Adaptor
{
    public class tester
    {
        public tester()
        {
            var myAdaptor = new Adaptor.Adaptor<Object>();
            myAdaptor.FooA(new ObjectA<T>());

        }
    }

}

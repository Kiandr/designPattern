using System;
namespace StructuralDesignPattern.Adaptor
{
    internal class Adaptor<T> : IAdaptor<T> where T : Object, new()
    {
        public Adaptor() { 
        }

        public T FooA(T objectA)
        {
            throw new NotImplementedException();
        }

        public T FooB(T objectB)
        {
            throw new NotImplementedException();
        }
    }

}
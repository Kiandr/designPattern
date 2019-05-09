using System;
namespace StructuralDesignPattern.Adaptor
{
    interface IAdaptor<T> where T : Object 
    {
        T FooA(T objectA);
        T FooB(T objectB);

    }
}

using System;
namespace StructuralDesignPattern.Adaptor
{
    public class ObjectA<T> : IObject<T> where T: Object
    {
        public ObjectA() { }
        public void Foo() => throw new NotImplementedException();

    }
}

using System;
namespace StructuralDesignPattern.Adaptor
{
    public class ObjectB<T> : IObject<T> where T: Object
    {
        public void Foo() => throw new NotImplementedException();
    }
}

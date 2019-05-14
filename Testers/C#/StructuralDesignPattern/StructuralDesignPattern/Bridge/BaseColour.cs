using System;
namespace StructuralDesignPattern.Bridge
{
    public class BaseColour : IColour
    {
        public BaseColour()
        {
        }

        public void ApplyColour()
        {
            throw new NotImplementedException();
        }
    }
}

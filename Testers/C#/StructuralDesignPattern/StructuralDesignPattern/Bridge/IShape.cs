using System;

namespace StructuralDesignPattern.Bridge
{
   interface IShape
    {
     void ApplyColour(IColour colour);
    }
}

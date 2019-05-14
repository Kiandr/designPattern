using System;
namespace StructuralDesignPattern.Bridge
{
    public class GreenColour : IColour
    {
        public void ApplyColour()
        {
            Console.WriteLine(" Applying Colour on Red Clour class");
        }
    }
}

using System;
namespace StructuralDesignPattern.Bridge
{
    public class RedColour : BaseColour
    {
        private IColour colour { get; set; }
        public RedColour() {
        
        }

        public virtual void ApplyColour() => Console.WriteLine(" Applying Colour on Red Clour class");
    }
}

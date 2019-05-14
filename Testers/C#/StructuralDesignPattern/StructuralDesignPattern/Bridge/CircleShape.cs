using System;
namespace StructuralDesignPattern.Bridge
{
    public class CircleShape : BaseShape
    {
        private IColour colour { get; set; }

        public CircleShape() : base() {
            
        }

        public void ApplyColour(IColour colour)
        {
            this.colour = colour;
        }
    }
}

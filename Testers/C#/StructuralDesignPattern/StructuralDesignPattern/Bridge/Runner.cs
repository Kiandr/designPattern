using System;
namespace StructuralDesignPattern.Bridge
{
    public class Runner
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                var red = new RedColour();
                var redCircle = new CircleShape( );
                redCircle.ApplyColour(red);


            }
        }
    }
}

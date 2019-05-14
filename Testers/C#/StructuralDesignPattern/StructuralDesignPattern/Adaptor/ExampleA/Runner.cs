using System;
namespace StructuralDesignPattern.Adaptor.ExampleA
{
    public class Runner
    {
        class MainClass
        {
            //public static void Main(string[] args)
            public void Main(string[] args)
            {

                int[] vs = { 1, 2, 3, 4, 5 };
                var adaptor = new Adaptor();
                var ls = adaptor.ConvertArrayToList(vs);
                foreach(var item in ls) {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

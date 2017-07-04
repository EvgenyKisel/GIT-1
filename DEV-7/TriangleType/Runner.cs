using System;

namespace TriangleType
{
    class Runner
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle();
                Inputer inputer = new Inputer();
                triangle.SideA = inputer.InputSide();
                triangle.SideB = inputer.InputSide();
                triangle.SideC = inputer.InputSide();
                
                Console.ReadKey();
            }
            catch 
            {

            }
        }
    }
}

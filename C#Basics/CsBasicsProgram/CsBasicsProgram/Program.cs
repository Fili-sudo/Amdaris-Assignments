using System;

namespace CsBasicsProgram 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle(2,2);
            IShape shape2 = new Rectangle(3, 2, 2);
            shape1.Draw();
            shape2.Draw();
            Console.WriteLine("Changing the attributes of shapes using properties");
            ((Circle)shape1).Radius = 3;
            ((Rectangle)shape2).Width = 6;
            ((Rectangle)shape2).Height = 2;
            shape1.Draw();
            shape2.Draw();
            ((Circle)shape1).Hello();
            ((Circle)shape1).Hello("custom Hello message");

            Console.WriteLine("");

            IShape[] shapesArray = new IShape[3]
            {
                new Circle(2,2),
                new Circle(3,2),
                new Rectangle(3,3,2),
            };
            ShapesCollection shapesList = new ShapesCollection(shapesArray);
            foreach (IShape shape in shapesList)
            {
                shape.Draw();
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public interface IShape
    {
        public void Draw();
    }

    public abstract class AbstractShape : IShape
    {
        protected readonly int dimension;
        public abstract void Draw();

        public AbstractShape(int dimension)
        {
            this.dimension = dimension;
        }

        public virtual void Hello()
        {
            Console.WriteLine("Generic Hello");
        }
        public void Hello(String msg)
        {
            Console.WriteLine(msg);
        }

    }

    public class Circle : AbstractShape
    {
        private int radius;

        public Circle(int radius, int dimension) : base(dimension)
        {
            this.radius = radius;
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a " + dimension + " dimension circle with radius " + radius);
        }
        public override void Hello()
        {
            Console.WriteLine("Hello from a Circle");
        }

    }
    public class Rectangle : AbstractShape
    {
        private int width, height;

        public Rectangle(int width, int height, int dimension) : base(dimension)
        {
            this.width = width;
            this.height = height;
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a " + dimension + " dimension rectangle with width " + width + " and height " + height);
        }
        public override void Hello()
        {
            Console.WriteLine("Hello from a Rectangle");
        }


    }
}

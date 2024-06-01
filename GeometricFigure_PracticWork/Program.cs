using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3
{
    abstract class GeometricFigure
    {
        protected string name;
        private int side;

        public int Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                {
                    side = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect side");
                }
            }
        }


        public GeometricFigure()
        {
            name = "no name";
            Side = 0;
        }
        public GeometricFigure(string n, int s)
        {
            name = n;
            Side = s;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name: {name}\nSide : {Side}");
        }
        public abstract void GetArea();
        public abstract void GetPerimetr();

    }
    class Rectangle : GeometricFigure
    {
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Inccorrect height!");
                }
            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect width!");
                }
            }
        }
        public Rectangle() : base()
        {
            this.height = 0;
            this.width = 0;
        }
        public Rectangle(string n, int s, int height, int width) : base(n, s)
        {
            Height = height;
            Width = width;
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area rectangle : {0.5 * width * height}");
        }
        public override void GetPerimetr()
        {
            Console.WriteLine($"Perimetr rectangle : {width * 3}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Height : {height}\nWidth : {width}");
        }

    }
    class Square : GeometricFigure
    {
        public override void GetArea()
        {
            Console.WriteLine($"Area square : {Side * Side}");
        }
        public override void GetPerimetr()
        {
            Console.WriteLine($"Perimetr square : {Side * 4}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Side : {Side}");
        }
        public Square(string n, int s) : base(n, s)
        {
            Side = s;
        }
    }
    class Diamond : GeometricFigure
    {
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Inccorrect height!");
                }
            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect width!");
                }
            }
        }
        public Diamond() : base()
        {
            this.height = 0;
            this.width = 0;
        }
        public Diamond(string n, int s, int height, int width) : base(n, s)
        {
            Height = height;
            Width = width;
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area square : {height * width}");
        }
        public override void GetPerimetr()
        {
            Console.WriteLine($"Perimetr square : {4 * Side}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Height : {height}\nWidth : {width}");
        }

    }
    class Parallelogram : GeometricFigure
    {
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Inccorrect height!");
                }
            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect width!");
                }
            }
        }
        public Parallelogram() : base()
        {
            this.height = 0;
            this.width = 0;
        }
        public Parallelogram(string n, int s, int height, int width) : base(n, s)
        {
            Height = height;
            Width = width;
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area square : {width * height}");
        }
        public override void GetPerimetr()
        {
            Console.WriteLine($"Perimetr square : {2 * (Side + Side)}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Height : {height}\nWidth : {width}");
        }

    }
    class Complete_figures
    {
        GeometricFigure[] figures;
        public Complete_figures()
        {
            figures = null;
        }
        public Complete_figures(GeometricFigure[] figures)
        {
            this.figures = figures;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", 10, 20, 35);
            rectangle.Print();
            rectangle.GetPerimetr();
            rectangle.GetArea();
            Square square = new Square("Square", 10);
            square.Print();
            square.GetPerimetr();
            square.GetArea();
            Diamond diamond = new Diamond("Diamond", 8, 10, 20);
            diamond.Print();
            diamond.GetPerimetr();
            diamond.GetArea();
            GeometricFigure[] figures = new GeometricFigure[4];
            figures[0] = square;
            figures[1] = diamond;
            figures[2] = rectangle;
        }
    }
}
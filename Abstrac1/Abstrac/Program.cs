using System;

namespace Abstrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chose one of them: ");
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("0.Exit");
            int input = int.Parse(Console.ReadLine());
         

            switch (input)
            {
                case 1:
                    Console.WriteLine("please enter the square side length: ");
                    int side = int.Parse(Console.ReadLine());
                    Square square = new Square(side);
                    square.CalcArea();
                    break;


                case 2:
                    Console.WriteLine("please enter the rectangle width: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("please enter the rectangler length: ");
                    int length = int.Parse(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(width, length);
                    rectangular.CalcArea();
                    break;

                case 0:
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("see you soon");
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("try to join");
                    break;
            }
        }
    }


    abstract class Figure
    {
        public abstract void CalcArea();
    }


    class Square : Figure
    {
        private int _side;

        public Square(int side)
        {
            Side = side;
        }

        public int Side
        {


            get { return _side; }


            set
            {
                if (_side < 0)
                {
                    Console.WriteLine("Try Again");
                    return;
                }
                _side = value;
            }
        }

        public override void CalcArea()
        {
            int SquareArea = Side * Side;
            Console.WriteLine($"Square Sahe:{SquareArea}");
            return;
        }
    }

    class Rectangular : Figure
    {
        private int _width;
        private int _length;


        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public int Length
        {
            get { return _length; }

            set
            {
                if (_length < 0)
                {
                    Console.WriteLine("length fals try again");
                    return;
                }
                _length = value;
            }
        }

        public int Width
        {
            get { return _width; }

            set
            {
                if (_width < 0)
                {
                    Console.WriteLine("length fals try again:");
                    return;
                }
                _width = value;
            }
        }

        public override void CalcArea()
        {
            int RecArea = Width * Length;
            Console.WriteLine($"Duzbucaqlinin Shesi: {RecArea}");
            return;
        }
    }






}






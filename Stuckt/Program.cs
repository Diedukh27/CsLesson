using System.Drawing;
using System.Xml.Schema;

namespace Stuckt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point car  = new Point();

            car.x = 20;
            car.Print();

            car.y = 10;
            car.Print();
        }
    }
}
public struct Point
{
    // properties
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public char symbol = '*';
    public string Model = "Mersedes";
    public int lenght = 3;
    public int landingheight = 10;
    public int enginecapacity = 1;
    public int power = 111;
    public int wheeldiameter = 1;
    public string color = "Red";
    public int max = 150;

    public Point() { }

    // methods
    public void Reset()
    {
        x = y = z = 0;
    }

    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
        Console.ResetColor();
        Console.WriteLine($"{Model}");
        Console.WriteLine($"{lenght}");
        Console.WriteLine($"{landingheight}");
        Console.WriteLine($"{enginecapacity}");
        Console.WriteLine($"{power}");
        Console.WriteLine($"{wheeldiameter}");
        Console.WriteLine($"{color}");
        Console.WriteLine($"{max}");

    }
}



    
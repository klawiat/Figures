using Figures.Library;
namespace Figures.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(0);
            Console.WriteLine(circle.Area);
        }
    }
}
using System;

namespace AreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CALCULADORA DE ÁREA E PERÍMETRO");

            Console.WriteLine("Insira a largura do retângulo: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a altura do retângulo: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("A área do retângulo é " + area + " e o peaametro é " + perimeter + ".");
        }
    }
}

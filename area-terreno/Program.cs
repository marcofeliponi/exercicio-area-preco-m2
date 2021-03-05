using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoM2, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoM2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = precoM2 * area;

            Console.WriteLine("Largura " + "= " + largura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento " + "= " + comprimento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area" + "= " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor" + "= " + preco.ToString("F2", CultureInfo.InvariantCulture));

            


        }
    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bar_OO {
    internal class Program {
        static void Main(string[] args) {
            Bill conta = new Bill();

            Console.Write("Informe o sexo (F ou M): ");
            conta.gender = char.ToUpper(Console.ReadKey().KeyChar);
            Console.ReadLine();
            Console.WriteLine($"Sexo registrado: {conta.gender}");

            Console.Write("Informe a quantidade de cerveja: ");
            conta.beer = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de Refrigerantes: ");
            conta.softDrink = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de Espetinhos: ");
            conta.barbecue = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------RELATORIO------------------");
            Console.WriteLine($"Consumo: R$ {conta.feeding().ToString("F2", CultureInfo.InvariantCulture)}");
            double totalCover = conta.cover(conta.feeding());
            if (totalCover == 0) {
                Console.WriteLine("Couvert: Isento de Couvert");
            }
            else {
                Console.WriteLine($"Couvert: R$ {totalCover.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"Ingresso: R$ {conta.ticket().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Total: R$ {conta.total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

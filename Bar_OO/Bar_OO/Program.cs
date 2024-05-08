using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine($"Consumo: R$ {conta.feeding():0.00}");
            double totalCover = conta.cover(conta.feeding());
            if (totalCover == 0) {
                Console.WriteLine("Couvert: Isento de Couvert");
            }
            else {
                Console.WriteLine($"Couvert: R$ {totalCover:0.00}");
            }

            Console.WriteLine($"Ingresso: R$ {conta.ticket():0.00}");
            Console.WriteLine($"Total: R$ {conta.total():0.00}");
        }
    }
}

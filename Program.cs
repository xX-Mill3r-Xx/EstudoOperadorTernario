using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstudoOperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo de um programa usando If Else

            /*Programa que le um valor de um produto e aplica um desconto 
             sobre o valor caso seja menor que 20.0*/

            //Console.Write("Entre com o valor do produto: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto;
            //if(preco < 20.0)
            //{
            //    desconto = preco * 0.01;
            //    preco = preco - desconto;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //    preco = preco - desconto;
            //}

            //Console.WriteLine($"O valor do desconto foi de R${desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"O Preço final do produto é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region Exemplo de um programa usando o Operador Ternario

            /*Aqui resolvemos o mesmo problema porem usando o Operador
             Ternario ao inves do if else;*/

            Console.Write("Entre com o valor do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            preco = preco - desconto;

            Console.WriteLine($"O valor do desconto foi de R${desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O Preço final do produto é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            Console.ReadLine();
        }
    }
}

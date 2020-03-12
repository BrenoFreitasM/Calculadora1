using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            c.addNumero(10.1);
            c.addNumero(2.1);
            c.addNumero(2.1);

            System.Console.WriteLine(c.multiplicar());


            System.Console.WriteLine(c.somar());
            

            c.addNumero(10);



            System.Console.ReadKey();
        }
    }
}

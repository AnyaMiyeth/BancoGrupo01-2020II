using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrupo01_2020II
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Ahorro(10000);
            string mensaje =cuenta.Consignar(50000);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }


    }

    
}

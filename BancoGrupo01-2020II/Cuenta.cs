using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrupo01_2020II
{
   public  abstract class Cuenta
    {
        public string Tipo { get; set; }

        public decimal Saldo { get; set; }

        public Cuenta(decimal saldo)
        {
            Saldo = saldo;
        
        }

        public abstract string Consignar(decimal valor);

        public abstract string Retirar(decimal valor);
        

        public string ConsultarSaldo()
        {
            return $"Su saldo es {Saldo}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrupo01_2020II
{
    class Ahorro:Cuenta
    {
        public Ahorro(decimal saldo):base(saldo)
        {

        }

        public override string Consignar(decimal valor)
        {
            if (valor > 0) 
            {
                Saldo += valor;
                return $"Se consigno {valor} su nuevo saldo es {Saldo}";
            }
            return $" No se consigno {valor} su saldo es {Saldo}";  
        }

        public override string Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}

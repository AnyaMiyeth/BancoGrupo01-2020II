using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrupo01_2020II
{
    class TarjetaCredito : IServicioFinanciero
    {
        public string Consignar(decimal valor)
        {
            return "Anya Bolaño";
        }

        public string Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}

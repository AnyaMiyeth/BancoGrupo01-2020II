using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrupo01_2020II
{
    interface IServicioFinanciero
    {
        string Consignar(decimal valor);
        string Retirar(decimal valor);
    }
}

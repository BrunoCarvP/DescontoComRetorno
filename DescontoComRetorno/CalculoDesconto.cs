using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoComRetorno
{
    internal class CalculoDesconto
    {
        public double Calculo(double valor , double desconto)
        {
            
            return  valor - (valor * desconto) / 100;
        }
    }
}

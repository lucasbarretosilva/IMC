using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Imc
    {
        public double Peso { get; set; }
        public double Altura { get; set; }


        public double CalcularImc()
        {
            return Peso / (Altura*Altura);
        }



    }


}

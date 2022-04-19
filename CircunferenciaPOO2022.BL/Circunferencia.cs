using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircunferenciaPOO2022.BL
{
    public class Circunferencia
    {
        //Atributos
        public int Radio { get; set; }

        //Constructores
        public Circunferencia()
        {
            
        }

        public Circunferencia(int medidaRadio)
        {
            Radio = medidaRadio;
        }
        //Métodos
        public bool Validar()
        {
            return Radio > 0;
        }

        public double GetPerimetro() => 2 * Math.PI * Radio;
        public double GetSuperficie() => Math.PI * Math.Pow(Radio, 2);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircunferenciaPOO2022.BL;

namespace CircunferenciaPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Circunferencia";
            int medidaRadio;
            bool error = true;
            bool errorObjeto = true;
            do
            {
                do
                {
                    Console.Write("Ingrese el valor del radio:");
                    if (!int.TryParse(Console.ReadLine(),out medidaRadio))
                    {
                        Console.WriteLine("ERROR: número no válido");
                        error = true;
                    }
                    else
                    {
                        error = false;
                    }
                } while (error);

                var circ = new Circunferencia(medidaRadio);
                if (circ.Validar())
                {
                    Console.WriteLine($"Superficie= {circ.GetSuperficie()}");
                    Console.WriteLine($"Perímetro.= {circ.GetPerimetro()}");
                    errorObjeto = false;
                }
                else
                {
                    Console.WriteLine("ERROR: Valor del radio no válido");
                }
                    

            } while (errorObjeto);

            Console.ReadLine();
        }
    }
}

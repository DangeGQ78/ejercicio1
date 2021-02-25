using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Principal
    {
        static void Main(string[] args)
        {
            double pulsacion=0;

            Persona persona = new Persona();

            Console.WriteLine("CALCULADORA DE PULSACIONES");

            Console.WriteLine("Diga su sexo M(masculino) o F(Femenino) :");

            persona.Sexo = Char.Parse(Console.ReadLine());

            Console.WriteLine("Diga su edad :");

            persona.Edad = Int32.Parse(Console.ReadLine());

            pulsacion= calcularPulsacion(persona);

            Console.WriteLine($"Sus pulsaciones son de {pulsacion} cada 10s de ejercicio aerobico");

            Console.ReadKey();
        }

        static public Double calcularPulsacion(Persona persona)
        {
            if (persona.Sexo=='m')
            {
                return (210 - persona.Edad) / 10;
            }
            else if (persona.Sexo == 'f')
            {
                return (220 - persona.Edad) / 10;
            }

            return 0;
        }

    }
}

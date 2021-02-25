using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana1
{
    class Principal
    {
        static void Main(string[] args)
        {
            String aprobo;
            double promedio;

            Console.WriteLine("Calculadora de aprobacion");
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Digite el nombre del estudiante :");

            estudiante.nombre = Console.ReadLine();

            Console.WriteLine("Digite la nota 1 :");

            estudiante.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la nota 2 :");

            estudiante.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la nota 3 :");

            estudiante.Nota3 = double.Parse(Console.ReadLine());

            promedio = calcularPromedio(estudiante);

            aprobo = determinarAprobacion(promedio);
            

            Console.WriteLine($"El estudiante {estudiante.nombre}  {aprobo} con una nota de : {promedio}");

            Console.ReadKey();


        }

        static public double calcularPromedio(Estudiante estudiante)
        {
            double promedio = ((estudiante.Nota1 + estudiante.Nota2 + estudiante.Nota3) / 3);
            return promedio;
        }

        static String determinarAprobacion(double promedio)
        {
            if (promedio>2.9)
            {
                return "Aprobo";
            }
            return "Reprobo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana1
{
    class Estudiante
    {
        public string nombre;
        private double nota1, nota2, nota3;

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }

        public Estudiante()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEjercicio3
{
    class Empleados
    {
        string[] Empleado = new string[4];
        double[] Sueldo;// = new double[10];

        public string[] Empleado1 { get => Empleado; set => Empleado = value; }
        public double[] Sueldo1 { get => Sueldo; set => Sueldo = value; }


        public Empleados()
        {
            Empleado[0] = "Martin";
            Empleado[1] = "Juan";
            Empleado[2] = "Julia";
            Empleado[3] = "Martina";

            Sueldo1 = new double[10] { 1000, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000 };
        }

       
    }
}

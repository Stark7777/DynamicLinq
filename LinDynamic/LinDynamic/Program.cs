using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinDynamic
{
    class Program
    {
        class Empleado
        {
            public string CodigoEmpleado { get; set; }
            public string Nombre { get; set; }
            public string Apelido { get; set; }
            public string Cedula { get; set; }
            public string Direccion { get; set; }
        }
        static void Main(string[] args)
        {
            //Instancia al contexto de datos
            Nomina_SAEntities contexto = new Nomina_SAEntities();
            //Use IQueryable LazyLoading
            IQueryable<Empleados> ListaEmpelados = contexto.Empleados.Where(e => e.SalarioMensual > 700);
            ListaEmpelados = ListaEmpelados.Take(10);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------Lista de Empleados Financiera Fundeser");

            foreach (Empleados e in ListaEmpelados)
            {
                Console.WriteLine("Codigo {0}", e.CodigoEmpleado);
                Console.WriteLine("Nombre {0}", e.Nombre);
                Console.WriteLine("Salario en ${0}", e.SalarioMensual);

                Console.WriteLine("###################################");
            }
          
        }
    }
}

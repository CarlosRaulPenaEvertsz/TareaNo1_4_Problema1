using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_4_Problema1
{
    class Empleado
    {
        private string Nombre;
        private decimal Sueldo;

        public void CargarDatos()
        {
            // Cargar Informacion

            Console.Write("Ingrese el Nombre del Empleado: ");
            Nombre=Console.ReadLine();

            int Continuar = 0;
            while (Continuar == 0)
            {
                Console.Write("Ingrese el Sueldo del Empleado: ");
                if (decimal.TryParse(Console.ReadLine(),out Sueldo) == true)
                {
                    Continuar = 1;
                } else
                {
                    Console.WriteLine("Error de Digitación, Intente Nuevamente");
                }
            }
        }

        public void ImprimirDatos()
        {
            // Impresion Datos Empleado

            Console.Clear();
            Console.WriteLine("Reporte de Empleado Registrado");
            Console.WriteLine("*******************************************\n");
            Console.WriteLine($"Nombre de Empleado: {Nombre} * Sueldo: {Sueldo.ToString("C")}");
            
            Console.WriteLine("\n\nFin del Listado.\nPresione Cualquier Tecla para Volver al Menú");
            Console.ReadKey();

        }
        public void CompromisosTributarios()
        {
            // Pago Impuestos

            Console.Clear();
            Console.WriteLine("Reporte de Compromisos Tributarios");
            Console.WriteLine("*******************************************\n");
            if (Sueldo > 30000)
            {
                Console.WriteLine($"El Contribuyente: {Nombre} * Debe Pagar Impuestos");
            } else
            {
                Console.WriteLine($"El Contribuyente: {Nombre} * Está Exento de Impuestos");
            }

            Console.WriteLine("\n\nFin del Listado.\nPresione Cualquier Tecla para Volver al Menú");
            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            int intOpcion = 0;

            while (intOpcion != 9)
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("**  MENU DE PROGRAMA IMPUESTOS EMPLEADO  **");
                Console.WriteLine("*******************************************");
                Console.WriteLine("1 - Registrar Datos Empleado               ");
                Console.WriteLine("2 - Imprimir Datos Empleado                ");
                Console.WriteLine("3 - Imprimir Estatus Impuestos             ");
                Console.WriteLine("9 - Para Salir                             ");
                Console.WriteLine("*******************************************");
                if (int.TryParse(Console.ReadLine(), out intOpcion) == false)
                {
                    intOpcion = 0;
                }
                if (intOpcion == 1)
                {
                    empleado.CargarDatos();
                }
                if (intOpcion == 2)
                {
                    empleado.ImprimirDatos();

                }
                if (intOpcion == 3)
                {
                    empleado.CompromisosTributarios();
                }
            }
        }
    }
}

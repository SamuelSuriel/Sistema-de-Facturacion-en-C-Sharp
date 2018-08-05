using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionLaMelma
{
    class Program
    {
        static void Main(string[] args)
        {
           var usuario = new Usuario();
            int option = 0;
            var x = Console.Out;
            List<string[]> operador = new List<string[]>();
             

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("INGRESAR AL SISTEMA:");
                Console.WriteLine();
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1. Crear nuevo usuario");
                Console.WriteLine("2. Ingresar con mi usuario");
                Console.WriteLine("3. Salir del sistema");
                Console.WriteLine();
                Console.Write("Por favor seleccione una opcion: ");

                var input = int.TryParse(Console.ReadLine(), out option);
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.Clear();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Crear nuevo usuario:");
                        Console.WriteLine("Nombre:");
                        usuario.FirstName = Console.ReadLine();
                        Console.WriteLine("Apellido:");
                        usuario.LastName = Console.ReadLine();
                        Console.WriteLine("Contraseña:");                        
                        usuario.password = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("  * * * * * * * * * * * * * * ");
                        Console.WriteLine("   Bienvenido/a  {0} ", usuario.FirstName);
                        Console.WriteLine("  * * *  * * *  * * * * * * * ");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------");

                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre:");
                        usuario.FirstName = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        usuario.LastName = Console.ReadLine();
                        Console.WriteLine("Ingrese una contraseña:");
                        usuario.password = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("  * * * * * * * * * * * * * * ");
                        Console.WriteLine("   Bienvenido/a  {0} ", usuario.FirstName);
                        Console.WriteLine("  * * *  * * *  * * * * * * * ");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(x);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Por favor ingresa una opcion valida!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("  * * * * * * * * * * * * * * ");
                Console.WriteLine("  *      F A C T U R A      * ");
                Console.WriteLine("  * * *  * * *  * * * * * * * ");
                Console.WriteLine("Ave.27 de Feb. esq. Tiradentes, Sto. Dgo.");
                Console.WriteLine(" Tel: (809) 555-0000 ");
                Console.WriteLine(" Facturaciones 'La Melma', S.A.");
                Console.WriteLine("RNC: 101696821 ");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("       AUTORIZADO POR LA DGII     ");
                Console.WriteLine(" ");
                Console.WriteLine("=========================================");
                Console.WriteLine("   FACTURA PARA CONSUMIDOR FINAL   ");
                Console.WriteLine("=========================================");
                do
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    string producto = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad del producto: ");
                    int Cant = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio unitario del producto: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    
                    double valventa = Cant * price;
                    double itbis = valventa * 0.18;
                    double precventa = valventa + itbis;

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El valor de venta es: ${0}", valventa);
                    Console.WriteLine("El Itbis es: ${0}", itbis);
                    Console.WriteLine("El precio total es: ${0}", precventa);
                    Console.WriteLine("=========================================");
                    Console.WriteLine();
                    Console.WriteLine(" Fuiste atendido por: Samuel Ramirez");
                    Console.WriteLine("Gracias por preferirnos! ");
                    Console.WriteLine("=========================================");
                }
                while (true);
            }
        }
    }
}

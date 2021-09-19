using CarritoDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    public class Menu
    {

        public static void MenuPrincipal()
        {
            Camisa camisa = new Camisa();
            Console.Title = "SHOPPING ONLINE DE CAMISAS - VENTAS DE MINORISTAS Y MAYORISTAS";
            bool salir = false;
            do
            {
                Console.Clear();

                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - VENTAS DE MINORISTAS Y MAYORISTAS");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine(" 1 - Añadir camisa al carro de compras");
                Console.WriteLine(" 2 - Eliminar camisa al carro de compras");
                Console.WriteLine(" 3 - Salir");
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("       - Cantidad de camisas en el carro de compras: "); CambiarColor(string.Format("{0}", camisa.getTotalCamisas()), ConsoleColor.Red);
                Console.Write("       - Precio Unitario: "); CambiarColor("$1000", ConsoleColor.Green);
                
                
                Console.Write("       - Precio total sin descuento: "); CambiarColor(string.Format("{0} $", camisa.getTotalPrice()), ConsoleColor.Green);
                
                Console.Write("       - Tipo de descuento aplicado: "); CambiarColor(string.Format("{0} %", camisa.getDiscount()), ConsoleColor.Red);
               
                Console.Write("       - Precio final con descuento: "); CambiarColor($"{camisa.getTotalPriceWithDiscount()} $", ConsoleColor.Green);
                
                
                
              
                Console.WriteLine("Ingrese una opcion del menú"); int.TryParse(Console.ReadLine(), out int opcion);

                switch (opcion)
                {
                    case 1:

                        camisa.addCamisa(1000);
                        break;
                    case 2:
                        camisa.removeCamisa();
                        break;
                    case 3:


                        bool salir2 = false;
                        do
                        {
                            //Console.Clear();
                            Console.WriteLine("¿Está seguro que desea salir? S/N");
                            string opcion2 = Console.ReadLine().ToLower();
                            if (opcion2 == "s") { salir = true; salir2 = true; };
                            if (opcion2 == "n") salir2 = true;

                        } while (!salir2);


                        break;
                }


            } while (!salir);
        }

        private static void CambiarColor(string mensaje, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }
    }
}

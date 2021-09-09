using CarritoDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Program
    {
        public static List<Remera> Remeras { get; set; }
        static void Main(string[] args)
        {

            Remeras = new List<Remera>();
            
            Console.Title = "SHOPPING ONLINE DE CAMISAS - VENTAS ED MINORISTAS Y MAYORISTAS";
            bool salir = false;
            do
            {
                Console.Clear();
                
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - VENTAS ED MINORISTAS Y MAYORISTAS");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine(" 1 - Añadir camisa al carro de compras");
                Console.WriteLine(" 2 - Eliminar camisa al carro de compras");
                Console.WriteLine(" 3 - Salir");
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("       - Cantidad de camisas en el carro de compras: "); CambiarColor(string.Format("{0}", Remeras.Count), ConsoleColor.Red);
                Console.Write("       - Precio Unitario: "); CambiarColor("$1000", ConsoleColor.Green);
                Console.Write("       - Precio total sin descuento: "); CambiarColor(ObtenerPrecioTotal().ToString() + "$", ConsoleColor.Green);
                Console.Write("       - Tipo de descuento aplicado: "); CambiarColor(ObtenerDescuento().ToString() + "%", ConsoleColor.Red);
                Console.Write("       - Precio final con descuento: "); CambiarColor(ObtenerPrecioTotalConDescuento().ToString() + "$", ConsoleColor.Green);
                /*
                
                
               
                Console.WriteLine("       - Precio final con descuento: ${0}", preciofinal);
                */
                Console.WriteLine("Ingrese una opcion del menú"); int.TryParse(Console.ReadLine(), out int opcion);

                switch (opcion)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Remove();
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

        private static float ObtenerPrecioTotal()
        {
            float precio = 0;
            foreach (Remera item in Remeras)
            {
                precio += item.Precio;
            }
            return precio;
        }

        private static float ObtenerPrecioTotalConDescuento()
        {
            float data = ObtenerPrecioTotal() - (ObtenerDescuento() * 100 / ObtenerPrecioTotal());
            if (data.ToString() == "NaN") data = 0;
            return data;
            
        }

        private static int ObtenerDescuento()
        {
            int descuento = 0;
            if (Remeras.Count >= 3 & Remeras.Count <= 5) descuento = 10;
            else if (Remeras.Count > 5) descuento = 20;
            return descuento;
        }

        private static void Add()
        {
            Remeras.Add(new Remera(1000));
        }

        private static void Remove()
        {
            if(Remeras.Count != 0) Remeras.RemoveAt(0);




        }


        private static void CambiarColor(string mensaje, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }
    }
}

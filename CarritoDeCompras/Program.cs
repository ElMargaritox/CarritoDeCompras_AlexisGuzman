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
        static void Main(string[] args)
        {
            
            Menu.MenuPrincipal();
            


            /*
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
            */
        }
    }
}

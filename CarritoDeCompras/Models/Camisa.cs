using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras.Models
{

    public class Camisa
    {
        private List<Camisa> camisasList { get; set; }
        private float precio { get; set; }
        private byte id { get; set; }
        public Camisa()
        {
            camisasList = new List<Camisa>();
            id = 0;
        }

        public Camisa(float precio)
        {
            this.precio = precio;
            this.id++;
        }
        public void addCamisa(float precio)
        {
            camisasList.Add(new Camisa(precio));
        }

        public int getTotalCamisas()
        {
            return this.camisasList.Count;
        }

        public void removeCamisa()
        {
            if (camisasList.Count != 0) camisasList.RemoveAt(0);
        }


        public float getTotalPrice()
        {
            float precio = 0;
            foreach (Camisa item in camisasList)
            {
                precio += item.precio;
            }
            return precio;
        }

        public float getTotalPriceWithDiscount()
        {
            float amount = getTotalPrice();

            amount -= getTotalPrice() * getDiscount() / 100;
            return amount;
        }
        public int getDiscount()
        {
            if (camisasList.Count >= 3 & camisasList.Count <= 5) return 10;
            else if (camisasList.Count > 5) return 20;
            else return 0;

        }
        
           

    }
}

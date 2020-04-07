using System;
using System.Collections.Generic;
namespace lab03jmzegers
{
    public class Producto
    {
        public string nombre;
        public string marca;
        public int precio;
        public int stock;

        public Producto(string nombre, string marca, int precio, int stock)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
        }
    }
}

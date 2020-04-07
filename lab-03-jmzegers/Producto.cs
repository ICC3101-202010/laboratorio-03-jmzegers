using System;
using System.Collections.Generic;
namespace lab03jmzegers
{
    public class Producto
    {
        protected string nombre;
        protected int precio;
        protected string marca;
        protected int stock;

        public Producto(string nombre, string marca, int precio, int stock)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
        }

        public List<Producto> ProdList()
        {
            Producto p1 = new Producto("galleta", "Oreo", 800, 2);
            Producto p2 = new Producto("galleta", "Tuareg", 800, 15);
            Producto p3 = new Producto("galleta", "Obsesion", 800, 30);
            Producto p4 = new Producto("cerveza", "Kunstmann", 3000, 10);
            Producto p5 = new Producto("cerveza", "Miller", 2500, 21);
            Producto p6 = new Producto("desodorante", "Speed Stick", 1200, 12);
            Producto p7 = new Producto("desodorante", "Old Spice", 1000, 10);
            Producto p8 = new Producto("bebida", "Coca Cola", 1000, 5);
            Producto p9 = new Producto("bebida", "Sprite", 800, 11);
            Producto p10 = new Producto("papas fritas", "Lays", 700, 9);
            Producto p11 = new Producto("papas fritas", "Pringles", 1000, 15);
            Producto p12 = new Producto("polera", "Kaya Unite", 3000, 5);
            Producto p13 = new Producto("polera", "Polo", 3000, 7);
            Producto p14 = new Producto("pisco", "Mistral", 4000, 10);
            Producto p15 = new Producto("pisco", "Alto del Carmen", 4000, 12);
            Producto p16 = new Producto("chocolate", "Bozzo", 2500, 14);
            Producto p17 = new Producto("chocolate", "Vizzio", 2500, 3);
            Producto p18 = new Producto("leche", "Colun", 1100, 5);
            Producto p19 = new Producto("leche", "Surlat", 1000, 7);
            Producto p20 = new Producto("leche", "Soprole", 1000, 10);
            List<Producto> ListaProd = new List<Producto>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20 };
            return ListaProd;
        }

        public void Main()
        {
            
        }
    }
}

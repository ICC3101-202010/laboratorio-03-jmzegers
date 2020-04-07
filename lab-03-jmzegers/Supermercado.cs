using System;
using System.Collections.Generic;
namespace lab03jmzegers
{
    public class Supermercado
    {
        public Supermercado()
        {
        }

        public Persona C1() //Metodo que le pide los datos al usuario, sea cliente o empleado.
        {
            Console.WriteLine("Escriba su RUT:");
            int rut = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Escriba su apellido:");
            string last_name = Console.ReadLine();

            Console.WriteLine("Escriba su dia de nacimiento:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su mes de nacimiento:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su anno de nacimiento:");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime birth_date = new DateTime(year, month, day);

            Console.WriteLine("Indique su nacionalidad:");
            string nationality = Console.ReadLine();

            Cliente c1 = new Cliente(rut, name, last_name, birth_date, nationality);
            return c1;
        }

        private Producto AgregarProd() //En caso de que un empleado desee agregar un producto a la lista
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string n = Console.ReadLine();

            Console.WriteLine("Ingrese la marca del producto");
            string m = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de stock disponible");
            int s = Convert.ToInt32(Console.ReadLine());

            Producto p1 = new Producto(n, m, p, s);
            return p1;
        }

        public List<Producto> ProdList() //Lista de los productos disponibles en el supermercado.
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

        static void Main()
        {
            Console.WriteLine("Bienvenid@ al supermercado A!");

            Console.WriteLine("¿Es usted un cliente o un miembro del personal? cliente/personal");
            string ans = Console.ReadLine();

            if (ans == "cliente")
            {
                Supermercado s = new Supermercado();
                Persona s1 = s.C1();

                Console.WriteLine("¿Desea hacer alguna compra? si/no");
                string answer = Console.ReadLine();

                while (answer != "no")
                {
                    if (answer == "si")
                    {
                        Console.WriteLine("Escriba el nombre del producto:");
                        string prod = Console.ReadLine();

                        Console.WriteLine("Escriba el nombre de la marca del producto:");
                        string marca = Console.ReadLine();

                        Supermercado s2 = new Supermercado();
                        List<Producto> prod1 = s2.ProdList();
                        Console.WriteLine(prod1)
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
                    }
                }
            }

            else if (ans == "personal")
            {

            }

            else
            {
                throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace lab03jmzegers
{
    public class Supermercado
    {
        public Supermercado()
        {
        }

        private Persona newCust()
        {
            Console.WriteLine("Escriba su RUT, sin puntos ni guiones. Si termina en K, reemplacelo por un 0:");
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

            Persona c1 = new Persona(rut, name, last_name, birth_date, nationality);
            return c1;
        }



        private Personal newEmp()
        {
            Console.WriteLine("Escriba su RUT, sin puntos ni guiones. Si termina en K, reemplacelo por un 0:");
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

            Console.WriteLine("Ingrese su puesto");
            string job = Console.ReadLine();

            Console.WriteLine("Coloque su sueldo");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique su horario (en horas/semana)");
            int hours = Convert.ToInt32(Console.ReadLine());

            Personal newEmployee = new Personal(rut, name, last_name, birth_date, nationality, job, salary, hours);
            return newEmployee;
        }



        private Producto AgregarProd() //En caso de que un empleado desee agregar un producto a la lista.
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



        private List<Producto> ProdList() //Lista de los productos disponibles en el supermercado.
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


        private List<Personal> EmpList() //Lista de los empleados que trabajan en el supermercado.
        {
            Personal e1 = new Personal(196369082, "Miguel", "Zegers", Convert.ToDateTime(1997 / 07 / 21), "Chilena", "cajero", 350000, 30);
            Personal e2 = new Personal(195686834, "Patricio", "Gonzalez", Convert.ToDateTime(1987 / 01 / 25), "Chilena", "jefe de local", 350000, 30);
            Personal e3 = new Personal(188548290, "Rafael", "Valenzuela", Convert.ToDateTime(1984 / 07 / 21), "Chilena", "supervisor", 350000, 30);
            Personal e4 = new Personal(102241367, "Ignacia", "Martinez", Convert.ToDateTime(1997 / 07 / 21), "Chilena", "cajero", 350000, 30);
            Personal e5 = new Personal(157026969, "Luis", "Valdes", Convert.ToDateTime(1990 / 07 / 21), "Chilena", "cajero", 350000, 30);
            Personal e6 = new Personal(142511518, "Manuela", "Pardo", Convert.ToDateTime(1991 / 07 / 21), "Chilena", "supervisor", 350000, 30);
            Personal e7 = new Personal(120353756, "Jorge", "Clavel", Convert.ToDateTime(1980 / 07 / 21), "Chilena", "auxiliar", 350000, 30);
            Personal e8 = new Personal(124920937, "Pablo", "Adell", Convert.ToDateTime(1986 / 07 / 21), "Chilena", "auxiliar", 350000, 30);
            Personal e9 = new Personal(167307139, "Isidora", "Pires", Convert.ToDateTime(1992 / 07 / 21), "Chilena", "jefe de local", 350000, 30);
            Personal e10 = new Personal(110901968, "Alfonso", "Caldero", Convert.ToDateTime(1987 / 07 / 21), "Chilena", "cajero", 350000, 30);
            List<Personal> ListaEmp = new List<Personal>() { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };
            return ListaEmp;
        }

        static void Main()
        {



            string contrasenna = ("hola");





            Console.WriteLine("Bienvenid@ al supermercado A!");

            Console.WriteLine("¿Es usted un cliente o un miembro del personal? cliente/personal");
            string ans = Console.ReadLine();

            if (ans == "cliente")
            {
                Supermercado s = new Supermercado();
                Persona s1 = s.newCust();

                Console.WriteLine("¿Desea hacer alguna compra? si/no");
                string answer = Console.ReadLine();

                List<Producto> listaCompras = new List<Producto>(); //La lista que ira guardando las compras del cliente.

                while (answer != "no")
                    //Creo un loop que agrega elementos a la lista de compras a medida que las compra.
                {
                    if (answer == "si")
                    {
                        Supermercado s2 = new Supermercado();
                        List<Producto> prod1 = s2.ProdList(); //Retorna una lista de los productos demarcados previamente.
                        Console.WriteLine("Los productos disponibles actualmente son:");
                        Console.WriteLine(prod1);

                        Console.WriteLine("Escriba el nombre del producto:");
                        string prod = Console.ReadLine();

                        Console.WriteLine("Escriba el nombre de la marca del producto:");
                        string tm = Console.ReadLine();

                        Console.WriteLine("Escriba la cantidad del producto deseada");
                        int cant = Convert.ToInt32(Console.ReadLine());

                        int mark = 0;

                        int i = 0;

                        while (i < prod1.Count)
                        {
                            if (prod1[i].nombre == prod && prod1[i].marca == tm)
                            //Revisa si existe el producto con el nombre y la marca previamente indicadas.
                            {
                                if (prod1[i].stock >= cant)
                                //Revisa si hay suficiente cantidad del producto para satisfacer al cliente.
                                {
                                    listaCompras.Add(prod1[i]);
                                    mark = 1;
                                }

                                else
                                {
                                    Console.WriteLine("Insuficiente stock");
                                }
                            }
                            i++;
                        }

                        if (mark == 0)
                            //Marcador que cambiaba a 1 si el producto existia en el supermercado
                            //De lo contrario, se mantenia con valor 0.
                        {
                            Console.WriteLine("Producto no existe en el supermercado");
                        }

                    }

                    else //Si el cliente da una respuesta diferente a sí o no en la pregunta.
                    {
                        throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
                    }
                    Console.WriteLine("¿Desea hacer mas compras? si/no");
                    answer = Console.ReadLine();
                    //De esta manera, se mantiene el loop que agrega cosas a la lista de compras hasta que ele cliente diga que no.
                }
                int i2 = 0;
                int precioTotal = 0;

                while (i2 < listaCompras.Count)
                    //Funcion que da el precio total de las compras del cliente.
                {
                    precioTotal = precioTotal + listaCompras[i2].precio;
                    i2++;
                }
                Console.WriteLine("Usted debe pagar un total de $" + precioTotal);
            }

            else if (ans == "personal")
                //Como no hace sentido que un miembro del personal cualquiera pueda alterar su puesto, sueldo u horario,
                //voy a asumir que el que esta ingresando es un encargado especial,
                //cuyo trabajo es alterar la base de datos a medida que sea necesario.
                //Por ello voy a pedir que ingrese una contraseña (se encuentra en la parte superior de la clase).
            {
                Console.WriteLine("Ingrese la contraseña:");
                string clave = Console.ReadLine();

                if (clave == contrasenna)
                {
                    Supermercado s = new Supermercado();
                    List<Personal> listaEmp2 = s.EmpList(); //Llamando a la lista de empleados

                    Console.WriteLine("¿Qué desea alterar? Responda(a/b/c)");
                    Console.WriteLine("a) Puesto, sueldo u horario de un empleado");
                    Console.WriteLine("b) Agregar elementos al inventario del establecimiento");
                    Console.WriteLine("c) Agregar o eliminar a algún miembro del personal");
                    string cambio = Console.ReadLine();

                    if (cambio == "a")
                    {
                        Console.WriteLine("¿Qué desea alterar? Responda(a/b/c)");
                        Console.WriteLine("a) Puesto");
                        Console.WriteLine("b) Sueldo");
                        Console.WriteLine("c) Horario");
                        string cambio2 = Console.ReadLine();

                        if (cambio2 == "a") //Cambiar el puesto.
                        {
                            Console.WriteLine("Ingrese el RUT del empleado");
                            int rutE = Convert.ToInt32(Console.ReadLine());
                            int i = 0;
                            while (i < listaEmp2.Count)
                            {
                                if (listaEmp2[i].rut == rutE)
                                {
                                    Console.WriteLine("Indique el puesto nuevo");
                                    string pNuevo = Console.ReadLine();
                                    Personal empACambiar = listaEmp2[i];
                                    int a1 = empACambiar.rut;
                                    string a2 = empACambiar.name;
                                    string a3 = empACambiar.last_name;
                                    DateTime a4 = empACambiar.birth_date;
                                    string a5 = empACambiar.nationality;
                                    int a7 = empACambiar.sueldo;
                                    int a8 = empACambiar.horario;

                                    Personal empCambiado = new Personal(a1, a2, a3, a4, a5, pNuevo, a7, a8);
                                    listaEmp2.RemoveAt(i);
                                    listaEmp2.Add(empCambiado);
                                }
                                i++;
                            }
                        }

                        else if (cambio2 == "b") //Cambiar el sueldo
                        {

                            Console.WriteLine("Ingrese el RUT del empleado");
                            int rutE = Convert.ToInt32(Console.ReadLine());
                            int i = 0;
                            while (i < listaEmp2.Count)
                            {
                                if (listaEmp2[i].rut == rutE)
                                {
                                    Console.WriteLine("Indique el sueldo nuevo");
                                    int sNuevo = Convert.ToInt32(Console.ReadLine());
                                    Personal empACambiar = listaEmp2[i];
                                    int a1 = empACambiar.rut;
                                    string a2 = empACambiar.name;
                                    string a3 = empACambiar.last_name;
                                    DateTime a4 = empACambiar.birth_date;
                                    string a5 = empACambiar.nationality;
                                    string a6 = empACambiar.puesto;
                                    int a8 = empACambiar.horario;

                                    Personal empCambiado = new Personal(a1, a2, a3, a4, a5, a6, sNuevo, a8);
                                    listaEmp2.RemoveAt(i);
                                    listaEmp2.Add(empCambiado);
                                }
                                i++;
                            }
                        }

                        else if (cambio2 == "c") //Cambiar el horario
                        {

                            Console.WriteLine("Ingrese el RUT del empleado");
                            int rutE = Convert.ToInt32(Console.ReadLine());
                            int i = 0;
                            while (i < listaEmp2.Count)
                            {
                                if (listaEmp2[i].rut == rutE)
                                {
                                    Console.WriteLine("Indique el horario nuevo");
                                    int hNuevo = Convert.ToInt32(Console.ReadLine());
                                    Personal empACambiar = listaEmp2[i];
                                    int a1 = empACambiar.rut;
                                    string a2 = empACambiar.name;
                                    string a3 = empACambiar.last_name;
                                    DateTime a4 = empACambiar.birth_date;
                                    string a5 = empACambiar.nationality;
                                    string a6 = empACambiar.puesto;
                                    int a7 = empACambiar.sueldo;

                                    Personal empCambiado = new Personal(a1, a2, a3, a4, a5, a6, a7, hNuevo);
                                    listaEmp2.RemoveAt(i);
                                    listaEmp2.Add(empCambiado);
                                }
                                i++;
                            }
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
                        }
                    }

                    else if (cambio == "b") //Si quiere alterar la base de datos de los productos del supermercado.
                    { 
                        Producto prodNuevo = s.AgregarProd(); //Esto retorna un producto nuevo.
                        s.ProdList().Add(prodNuevo);
                    }

                    else if (cambio == "c") //Si quiere agregar o eliminar a algún miembro del personal
                    {
                        Console.WriteLine("¿Qué desea hacer? (responder a/b)");
                        Console.WriteLine("a) Eliminar a un empleado de la lista");
                        Console.WriteLine("b) Agregar un empleado nuevo");
                        string cambio2 = Console.ReadLine();

                        Console.WriteLine("Ingrese el RUT del empleado");
                        int rutE = Convert.ToInt32(Console.ReadLine());
                        int i = 0;
                        while (i < listaEmp2.Count)
                        {
                            if (listaEmp2[i].rut == rutE)
                            {
                                if (cambio2 == "a")
                                {
                                    listaEmp2.RemoveAt(i);
                                }

                                else if (cambio2 == "b")
                                {
                                    Personal newEmp = s.newEmp();
                                    listaEmp2.Add(newEmp);
                                }
                            }
                            i++;
                        }
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
                    }
                }
            }

            else
            {
                throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
            }
        }
    }
}

using System;
namespace lab03jmzegers
{
    public class Guia
    {
        private Persona p1;

        public Persona P1
        {
            get
            {
                return p1;
            }

            set
            {
                Console.WriteLine("¿Es usted cliente o miembro del personal?, cliente/personal");
                string answer = Console.ReadLine();

                Console.WriteLine("Escriba su RUT:");
                int r = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba su nombre:");
                string n1 = Console.ReadLine();

                Console.WriteLine("Escriba su apellido:");
                string a = Console.ReadLine();

                Console.WriteLine("Escriba su dia de nacimiento:");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba su mes de nacimiento:");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba su anno de nacimiento:");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime bDay = new DateTime(year, month, day);

                Console.WriteLine("Indique su nacionalidad:");
                string n2 = Console.ReadLine();

                if (answer == "cliente")
                {
                    Persona p1 = new Cliente(r, n1, a, bDay, n2);
                    this.p1 = value;
                }

                else if (answer == "personal")
                {
                    Console.WriteLine("Indique su puesto actual");
                    string p = Console.ReadLine();

                    Console.WriteLine("Indique su sueldo actual");
                    int s = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indique su horario actual");
                    int h = Convert.ToInt32(Console.ReadLine());

                    Persona p1 = new Personal(r, n1, a, bDay, n2, p, s, h);
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Respuesta invalida");
                }
            }
        }

        
        static void Main()
        {
            Console.WriteLine("Hola!");
            Console.WriteLine(P1);

        }
    }
}
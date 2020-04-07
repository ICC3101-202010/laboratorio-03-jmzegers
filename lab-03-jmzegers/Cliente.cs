using System;
namespace lab03jmzegers
{
    public class Cliente : Persona
    {
        public Cliente(int rut, string name, string last_name, DateTime birth_date, string nationality)
            : base(rut, name, last_name, birth_date, nationality)
        {
        }

        public Cliente New_cliente()
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
    }
}

using System;
namespace lab03jmzegers
{
    public class Cliente : Persona
    {
        public Cliente(int rut, string name, string last_name, DateTime birth_date, string nationality)
            : base(rut, name, last_name, birth_date, nationality)
        {
        }

        
        }
    }
}

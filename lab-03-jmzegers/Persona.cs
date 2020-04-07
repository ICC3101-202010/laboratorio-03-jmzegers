using System;
using System.Collections.Generic;

namespace lab03jmzegers
{
    public class Persona
    {
        public int rut;
        public string name;
        public string last_name;
        public DateTime birth_date;
        public string nationality;

        public Persona(int rut, string name, string last_name, DateTime birth_date, string nationality)
        {
            this.rut = rut;
            this.name = name;
            this.last_name = last_name;
            this.birth_date = birth_date;
            this.nationality = nationality;
        }
    }
}

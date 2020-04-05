using System;

namespace lab03jmzegers
{
    public class Persona
    {
        protected int rut;
        protected string name;
        protected string last_name;
        protected DateTime birth_date;
        protected string nationality;

        public Persona(int rut, string name, string last_name, DateTime birth_date, string nationality)
        {
            this.rut = rut;
            this.name = name;
            this.last_name =  last_name;
            this.birth_date = birth_date;
            this.nationality = nationality;
        }
    }
}

using System;
namespace lab03jmzegers
{
    public class Personal : Persona
    {
        public string puesto;
        public int sueldo;
        public int horario;

        public Personal(int rut, string name, string last_name, DateTime birth_date, string nationality,
            string puesto,
            int sueldo,
            int horario)
            : base(rut, name, last_name, birth_date, nationality)
        {
            rut = this.rut;
            name = this.name;
            last_name = this.last_name;
            birth_date = this.birth_date;
            nationality = this.nationality;
            puesto = this.puesto;
            sueldo = this.sueldo;
            horario = this.horario;
        }
    }
}

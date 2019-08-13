using System;
using System.Collections.ObjectModel;

namespace MVVMProject.Models
{
    public class PersonaCollection : ObservableCollection<Persona>
    {

    }

    public class Persona
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private DateTime _fechaNac;
        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public Persona()
        {

        }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Persona(int id, string nombre, DateTime fechaNac)
        {
            Id = id;
            Nombre = nombre;
            FechaNac = fechaNac;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

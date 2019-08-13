using MVVMProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProject.Connectors
{
    public class DbConnector
    {
        /// <summary>
        /// listarPersonas is a class for list any person
        /// </summary>
        /// <returns> people </returns>
        public PersonaCollection listarPersonas()
        {
            PersonaCollection lista = new PersonaCollection();
            lista.Add(new Persona(1, "Pedro"));
            lista.Add(new Persona(2, "Juan"));
            lista.Add(new Persona(3, "Diego"));
            lista.Add(new Persona(4, "Luis"));
            //Tuplas que me invento
            lista.Add(new Persona(5, "Pablo"));
            
            return lista;
        }
        /*
        public void listarPersonas(PersonaCollection lista)
        {
            lista.Add(new Persona(1, "Pedro"));
            lista.Add(new Persona(2, "Juan"));
            lista.Add(new Persona(3, "Diego"));
            lista.Add(new Persona(4, "Luis"));
        }
        */
    }
}

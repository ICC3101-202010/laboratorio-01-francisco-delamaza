using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Person
    {
        //Atributo
        private String nombre;
        private String apellido;

        public Person(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void Lanzar()
        {
            int randomNumber = new Random().Next(0, 2);
            Console.WriteLine(randomNumber);
        }

    }
}

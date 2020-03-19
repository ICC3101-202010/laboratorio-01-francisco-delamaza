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
        private string name;
        private string lastname;

    
      


    public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;

        }


        public void Lanzar()
        {
            int randomNumber = new Random().Next(0, 3);
            Console.WriteLine(randomNumber);
        }

    }
}

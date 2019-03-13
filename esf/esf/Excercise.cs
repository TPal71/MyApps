using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Excercise
    {
        /// <summary>
        /// Adattagok létrehozása: public, private, protedted
        /// Public : nyilvános elérés
        /// Private: csak az osztály számára látszik
        /// </summary>
        public string Name;

        //Konstruktor: Inicializálja az osztály adattagjait
        public Excercise(string aName)
        {
            Name = aName;
        }
        
       //Tagfüggvény
        public void printName()
        {
            Console.WriteLine(Name);
           
        }
        // Másik tagfüggvény
        public string getName()
        {
            return Name;
        }



    }
}

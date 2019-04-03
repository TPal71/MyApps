using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {


            Cat myCat = new Cat("Cirmi",true);

            Cat sonCat = new Cat("Kormi",false);

            Dog myDog = new Dog("Kinga",true);

            myCat.Sleep();
            myCat.Hunt();

            myCat.Sound();
            myDog.Sound();

            myDog.Born(2);
            myDog.Child();

          
            myCat.Born(4);
            myCat.Child();

            sonCat.Born(2);
            sonCat.Child();


            Console.ReadKey();

          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        protected string Name;
        protected bool isFemale;//true : nőstény, ha false: akkor him 

        abstract public void Sleep();
        abstract public void Hunt();
        abstract public void Sound();
        abstract public void Born(int i);
    }

    class Cat : Animal
    {

        private List<Cat> Kids;

        public Cat(string aName,bool aGender)
        {
            Name = aName;
            isFemale = aGender;
        }

        public override void Born(int v)
        {
            if (isFemale)
            {
                Kids = new List<Cat>();
                for (int i = 0; i < v; i++)
                {
                    Kids.Add(new Cat("cica" + i.ToString(), true));
                }
            }
            
        }

        public void Child()
        {
            if (Kids != null)
            {
                foreach (var item in Kids)
                {
                    Console.WriteLine(Name + "'s child name: " + item.Name);
                }
            }
            else
            {
                Console.WriteLine(Name + " nem szülhet");
            }
        }

        public Cat()
        {
        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " nyávog....");
        }
    }
    class Dog : Animal
    {

        private List<Dog> Kids;
        //KOnstruktor
        public Dog(string aName, bool aGender)
        {
            Name = aName;
            isFemale = aGender;
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + "  ugat....");
        }

        public override void Born(int v)
        {
            if (isFemale)
            {
                Kids = new List<Dog>();
                for (int i = 0; i < v; i++)
                {
                    Kids.Add(new Dog("kutyus" + i.ToString(), true));
                }
            }
            else
            {
                Console.WriteLine(Name +" nem szülhet");
            }

        }

        public void Child()
        {
            if (Kids != null)
            {
                foreach (var item in Kids)
                {
                    Console.WriteLine(Name + "'s child name: " + item.Name);
                }
            }
        }
    }
}

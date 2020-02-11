using System;

namespace AbtrasctVsStatic
{


    public abstract class Creature
    {

        //cuando algo es abstracto entonces es algo que es muy raro o poco completo 
        //pero tiene cosas que se comparten con cosas
        //solo se delcara
        public abstract void eat();

        //cuando algo es virtual es que puedes hacer override, solo se usa cosas MUUY especificas 
        public virtual void Communicate()
        {

        }

        public static void poop()
        {
            Console.WriteLine("poop!");
        }
    }

    public class Person : Creature
    {


        public override void Communicate()
        {
            Console.WriteLine("I am a human, so i say hi, 'HI'");

        }

        public override void eat()
        {
            Console.WriteLine("YUUM YUUM!");
        }
    }

    public class Dog : Creature
    {
        public override void Communicate()
        {
            Console.WriteLine("I am a dog, so I bark, 'BARK'");
        }
        public override void eat()
        {
            Console.WriteLine("SNAARL");
        }

    }

    public class Bird : Creature
    {

        public override void Communicate()
        {
            Console.WriteLine("CHIRP");
        }
        public override void eat()
        {
            Console.WriteLine("puuku");
        }

        public static void fly()
        {
            Console.WriteLine("flyLine");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var dog = new Dog();
            var bird = new Bird();

            //esto es estatico
            Console.WriteLine("Hello Human!");

            person.Communicate();

            Console.WriteLine("Hello dog!");

            dog.Communicate();

            Console.WriteLine("Hello bird!");

            //no se pudo crear una instancia de Bird
            bird.Communicate();

            Console.WriteLine("Please eat Human");

            person.eat();



            Console.WriteLine("Please eat Dog");

            bird.eat();

            Console.WriteLine("Please eat Bird");

            bird.eat();

            Console.WriteLine("Please fly Bird");

            Bird.fly();


            




        }
    }
}

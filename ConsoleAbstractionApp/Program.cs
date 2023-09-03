using Mammals;

namespace AbstractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 10));

            var dog = new Dog();
            var cat = new Cat();
            dog.MakeSound();
            cat.MakeSound();
            dog.GoPlay();
            cat.GoPlay();
            dog.Walk();
            cat.Walk();

            Console.WriteLine(new string('*', 10));
        }
    }
}
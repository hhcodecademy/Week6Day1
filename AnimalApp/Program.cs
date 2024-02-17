namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog();
            animal1.animalSound("dog");
            animal1.sleep();
            animal1.eat();

            Animal animal2 = new Cow();
            animal2.animalSound("cow");
            animal2.sleep();
            animal2.eat();
        }
    }
}

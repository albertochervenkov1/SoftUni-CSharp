using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Puppy sharo = new Puppy();
            sharo.Eat();
            sharo.Bark();
            sharo.Weep();

            Cat tommy = new Cat();
            tommy.Eat();
            tommy.Meow();
        }
    }
}

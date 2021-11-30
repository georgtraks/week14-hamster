using System;

namespace ooppet
{
    class Program
    {
        class pet
        {
            string name;
            int age;
            double weight;
            public pet(string _name) {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"congratulations! you´ve adopted {name}.");

            }

            public double Weight {

                get { return weight; }
            }

            public void showpetinfo()
            {
                Console.WriteLine($"name: {name}.");
                Console.WriteLine($"age: {age}.");
                Console.WriteLine($"weight: {weight}.");
            }

            public void eat()
            {
                weight += 0.2;
                    Console.WriteLine("crunch-munch");
            }
            public void Run()
            {
                weight -= 0.1;
                Console.WriteLine("WOOOOOOM!!!!!!!");
            }
           // ~pet()
           //{
           //  Console.WriteLine($"R.I.P {name}");
           //}


        }
        static void Main(string[] args)
        {
            pet mypet = new pet("hamster");
            mypet.showpetinfo();

            for(int i = 0; i < 10; i++)
            {
               mypet.eat();
               Console.WriteLine($"current weight: {mypet.Weight}");
                if(mypet.Weight >= 0.7)
                {
                    while (mypet.Weight > 0.7)
                    {
                        mypet.Run();
                        Console.WriteLine($"weight after workout: {mypet.Weight}");
                    }
                }
            }

            //GC.Collect();


        }
    }
}

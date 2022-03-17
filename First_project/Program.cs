using System;

namespace FirstProject
{
    class Program
    {
        public void getData()
        {

            Console.WriteLine("I am inside the method");
         
        }
        static void Main(string[] args)
        {
            
            Program p = new Program();
            p.getData();

            Console.WriteLine("Hello World!");

            int a = 4;
            Console.WriteLine("Number is " + a);

            String name = "Olzhas";
            Console.WriteLine("Name is " + name);

            Console.WriteLine($"Name is {name}");

            var age = 30;
            Console.WriteLine("Age is " + age);

            dynamic height = 3.15;
            Console.WriteLine("Height is " + height);
                
            height = "meters";
            Console.WriteLine($"Height is {height}");

            





        }
    }
    

}


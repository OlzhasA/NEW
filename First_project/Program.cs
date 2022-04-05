using System;

namespace FirstProject
{
    class Program:Program4
    {
        String name;
        String lastName;

        //constructors
        public Program(String name) 
        {
            this.name = name;
        }
        public Program(String firstName, String lastName)
        {
            this.name=firstName;
            this.lastName=lastName;
        }

        public void getName()
        {
            
            Console.WriteLine("My name is " + this.name);
            
        }
        public void getlastName()
        {
            Console.WriteLine("My surname is " + this.lastName);
        }

        public void getData()
        {
            Console.WriteLine("I am inside the method");       
        }

        static void Main(string[] args)
        {
            
            Program p = new Program("Olzhas");
            Program p1 = new Program("Olzhas","Agubayev");
            p.getData();
            p.getName();
            p.getlastName();
            p.setData();

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


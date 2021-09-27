using System;

namespace VariablesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            string dogName;
            int dogAge;
            char s;
            bool isAlive = true;
            double dogLength = 25;
            decimal dogWeight = 66;
          
            Console.Write("What is your dog name?");
            dogName = Console.ReadLine();

            Console.Write($"What is {dogName} age?");
            dogAge = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
            Console.WriteLine($"{dogName} weighs {dogWeight}, And dog is {dogLength} inches");
           
        }
    }
}

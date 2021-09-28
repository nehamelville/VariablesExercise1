using System;

namespace VariablesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            string dogName = "Raulph";
            int dogAge = 4;
            char initial = 'N';
            bool isDalmation = true;
            double dogLength = 25.4;
            decimal dogWeight = 66.4m;
          
            /*
              Console.Write("What is your dog name? ");
            dogName = Console.ReadLine();
            Console.Write($"What is {dogName} age? ");
            dogAge = Convert.ToInt32(Console.ReadLine());
            */

            Console.WriteLine($"My dog's name is {dogName} {initial}. " +
                $"He is {dogAge} years old. {dogName} weighs {dogWeight}lbs " +
                $"and {dogLength} inches long and he is {(isDalmation ? "a Dalmation" : "unknown")}.");
            
           
        }
    }
}

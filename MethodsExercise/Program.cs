using System.Numerics;

namespace MethodsExercise
{
    public class Program
    {
        public static void JediStory()
        {
            Console.WriteLine("What is Jedi's name?");
            string jediname = Console.ReadLine();
            Console.WriteLine($"Hello, {jediname}! What color is your lightsaber?");
            string sabercolor = Console.ReadLine();
            Console.WriteLine("What is Sith's name?");
            string sithname = Console.ReadLine();
            Console.WriteLine($"Hello, {sithname}! What color is your lightsaber?");
            string sithsabercolor = Console.ReadLine();
            Console.WriteLine("What planet was the duel on?");
            string planet = Console.ReadLine();
            
            Console.WriteLine($"A long time ago in a galaxy far far away there was a Jedi named {jediname}, who had a {sabercolor} lightsaber. {jediname} was giving the task to defeat sithlord {sithname}, who had a {sithsabercolor} lightsaber. {jediname} set a course for {planet} where {sithname} was last seen. If you are a true Star Wars fan you know the rest.obi");
            
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            
            return sum;
        }
        
        static void Main(string[] args)
        {
            //JediStory();
            //Console.WriteLine(Add(numOne: 1, numTwo: 2));
            //Console.WriteLine(Subtract(numOne: 1, numTwo: 2));
            //Console.WriteLine(Multiply(numOne: 1, numTwo: 2));
            //Console.WriteLine(Divide(numOne: 1, numTwo: 2));
            //Console.WriteLine(Sum(6, 6, 6));
        }
    }
}

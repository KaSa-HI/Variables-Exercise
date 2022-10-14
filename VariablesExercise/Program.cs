namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Variables Exercise");

            string dogName = "Arai";
            int dogAge = 8;
            char myDog = '4';
            bool myDogIsFawn = true;
            bool isHappy = false;
            double pugHeight = 24.3;
            decimal pugWeight = 15.8M;

            Console.WriteLine(@$"My Pugs name is {dogName}, He is {dogAge} years old, He is healthy with {myDog} legs. Is he fawn coloured? {myDogIsFawn}");
            Console.WriteLine(@$"Arais height is {pugHeight}inches. This ball of loverolls is {pugWeight}lbs.");
        }
    }
}
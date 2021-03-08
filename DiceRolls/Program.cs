using System;

namespace DiceRolls
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            sum += Dice.RollOutcome();
            sum += Dice.RollOutcome();
            sum += Dice.RollOutcome();
            sum += Dice.RollOutcome();
            sum += Dice.RollOutcome();
            Console.WriteLine(sum);
            Console.ReadLine();


            /*
            //Another Approach             
            Random _random = new Random();

            for (int i = 0; i < 6; i++)
            {
                sum += _random.Next(1, 7);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */

        }
    }
}

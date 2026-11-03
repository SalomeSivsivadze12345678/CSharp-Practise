
using DiceRollGame1.UserCommunication;


namespace DiceRollGame1.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var DiceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess the number in {InitialTries} tries.");


            var triesLeft = InitialTries;

            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number");
                if (guess == DiceRollResult)
                {
                    return GameResult.Victory;

                }
                Console.WriteLine("Wrong Number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameresult)
        {
            string message = gameresult == GameResult.Victory ? "You won" : "You lost";
            Console.WriteLine(message);
        }

}
    
}

using System;

namespace LadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //while (true)
            //{
                var moveCount = RunRandomSimulation(random);
                Console.WriteLine(moveCount);
            //    Console.ReadLine();
            //}
        }

        private static int RunRandomSimulation(Random random)
        {
            var board = new Board(1);
            var player = board.GetPlayer(0);
            var count = 0;
            while (player.CurrentSquareIndex != 90)
            {
                var randomDice = random.Next(1, 7);
                player.Move(randomDice);
                Console.WriteLine(count + " " + player.CurrentSquareIndex);
                count++;
            }

            return count;
        }
    }
}

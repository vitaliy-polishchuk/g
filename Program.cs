using System;
using System.Threading;


namespace TIC_TAC_TOE

{

    class Program

    {      
        static void Main(string[] args)

        {
            Game game = new Game();
            Board board = new Board();
         
            do
            {
                Console.Clear();

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                string chance = game.ChangeChance();

                Console.WriteLine(chance);

                Console.WriteLine("\n");

                board.WriteBoard(game);

                game.choice = int.Parse(Console.ReadLine());

                string choiceGame = game.GetChoice();

                Console.WriteLine(choiceGame);



                game.flag = game.CheckWin();

            } while (game.flag != 1 && game.flag != -1);


            Console.Clear();

            board.WriteBoard(game);

            string isFlag = game.CheckFlag();
            Console.WriteLine(isFlag);

            Console.ReadLine();

        }

    }
}
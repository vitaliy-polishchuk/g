using System;

    public class Board
    {
        public void WriteBoard(Game game)

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", game.arr[1], game.arr[2], game.arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", game.arr[4], game.arr[5], game.arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", game.arr[7], game.arr[8], game.arr[9]);

            Console.WriteLine("     |     |      ");

        }
    }

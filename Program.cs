using System;
using System.Threading;


namespace TIC_TAC_TOE

{

    class Program

    {

        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static int player = 1;

        public static int choice;

        public static int flag = 0;


        static void Main(string[] args)

        {

            do

            {

                Console.Clear();

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");
                string chance = Game.ChangeChance();

                Console.WriteLine(chance);


                Console.WriteLine("\n");

                Board();

                choice = int.Parse(Console.ReadLine());

                string choiceGame = Game.GetChoice();

                Console.WriteLine(choiceGame);



                flag = Game.CheckWin();

            } while (flag != 1 && flag != -1);


            Console.Clear();

            Board();

            string isFlag = Game.CheckFlag();
            Console.WriteLine(isFlag);

            Console.ReadLine();

        }

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }



    }

    ////////////////////////////////////////////////////////

   
}
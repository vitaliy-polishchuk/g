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

   class Game
    {

        public static string CheckFlag()
        {
            if (Program.flag == 1)

            {

                return "Player {0} has won" + (Program.player % 2) + 1;

            }

            else

            {

                return "Draw";

            }
        }
        public static string GetChoice()
        {
            if (Program.arr[Program.choice] != 'X' && Program.arr[Program.choice] != 'O')

            {

                if (Program.player % 2 == 0)

                {

                    Program.arr[Program.choice] = 'O';

                    Program.player++;

                }

                else

                {

                    Program.arr[Program.choice] = 'X';

                    Program.player++;

                }

            }

            else

            {

                return "Sorry the row {0} is already marked with {1}" + Program.choice + Program.arr[Program.choice];



            }
            return "";

        }
        public static string ChangeChance()

        {

            if (Program.player % 2 == 0)

            {

                return "Player 2 Chance";

            }

            else

            {

                return "Player 1 Chance";

            }
            
        }
        public static int CheckWin()
        {

            #region Horzontal Winning Condtion



            if (Program.arr[1] == Program.arr[2] && Program.arr[2] == Program.arr[3])

            {

                return 1;

            }



            else if (Program.arr[4] == Program.arr[5] && Program.arr[5] == Program.arr[6])

            {

                return 1;

            }



            else if (Program.arr[6] == Program.arr[7] && Program.arr[7] == Program.arr[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion



            else if (Program.arr[1] == Program.arr[4] && Program.arr[4] == Program.arr[7])

            {

                return 1;

            }



            else if (Program.arr[2] == Program.arr[5] && Program.arr[5] == Program.arr[8])

            {

                return 1;

            }



            else if (Program.arr[3] == Program.arr[6] && Program.arr[6] == Program.arr[9])

            {

                return 1;

            }

            #endregion


            #region Diagonal Winning Condition

            else if (Program.arr[1] == Program.arr[5] && Program.arr[5] == Program.arr[9])

            {

                return 1;

            }

            else if (Program.arr[3] == Program.arr[5] && Program.arr[5] == Program.arr[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw



            else if (Program.arr[1] != '1' && Program.arr[2] != '2' && Program.arr[3] != '3' && Program.arr[4] != '4' && Program.arr[5] != '5' && Program.arr[6] != '6' && Program.arr[7] != '7' && Program.arr[8] != '8' && Program.arr[9] != '9')

            {

                return -1;

            }

            #endregion

            else

            {

                return 0;

            }

        }
    }

}
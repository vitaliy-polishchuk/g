 public class Game
    {     
        
        public char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public int player = 1;

        public int choice;

        public int flag = 0;

        public string CheckFlag()
        {
            if (flag == 1)

            {

                return "Player {0} has won" + (player % 2) + 1;

            }

            else

            {

                return "Draw";

            }
        }
        public string GetChoice()
        {
            if (arr[choice] != 'X' && arr[choice] != 'O')

            {

                if (player % 2 == 0)

                {

                    arr[choice] = 'O';

                    player++;

                }

                else

                {

                    arr[choice] = 'X';

                    player++;

                }

            }

            else

            {

                return "Sorry the row {0} is already marked with {1}" + choice + arr[choice];



            }
            return "";

        }
        public string ChangeChance()

        {

            if (player % 2 == 0)

            {

                return "Player 2 Chance";

            }

            else

            {

                return "Player 1 Chance";

            }

        }
        public int CheckWin()
        {

            #region Horzontal Winning Condtion



            if (arr[1] == arr[2] && arr[2] == arr[3])

            {

                return 1;

            }



            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {

                return 1;

            }



            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion



            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            }



            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            }



            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {

                return 1;

            }

            #endregion


            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {

                return 1;

            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw



            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

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

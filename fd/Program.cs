using System;

namespace fd
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] startBoard =
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };
            char[,] gameBoard = startBoard.Clone() as char[,];

            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true;

            ////////////////////////////////////

            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                //TODO: draw the board

                if (nextIsPlayer1)
                {
                    //TODO: player 1 move
                    nextIsPlayer1 = false;
                }
                else
                {
                    //TODO: player 2 move
                    nextIsPlayer1 = true;
                }
                if (player1Won || player2Won)
                    break;
            }

            ///////////////////////////////

            Console.Clear();
            //TODO: draw the board
            Console.WriteLine("Game ended!");
            // TODO: print who won
        }
    }
}

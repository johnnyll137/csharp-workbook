using System;

namespace ConsoleApplication
{
    public class TicTacToe
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
         };

        public void Run()
        {
            while (!CheckForWin())
            {
                playerTurn = playerTurn == "X" ? "0" : "X";
                DrawBoard();
                GetInput();
            }
            DrawBoard();
            Console.WriteLine(string.Format("Congrats Player {0}.  You have WON!!!", playerTurn));
        }

        public static void GetInput()
        {
            //We are asking the user for date throught prompts
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");

            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");

            int column = Int32.Parse(Console.ReadLine());

            //Doing somthing with the user date
            if (PlaceMark(row, column)){
                return;
                }
                else{
                    Console.WriteLine("A mark already exists in this spot");
                    GetInput();
                }

        }

        public static bool PlaceMark(int row, int column)
        {
            //What variables holds the mark (X or Y)?
            //playerturn
            var mark = board[row][column];
            if (string.IsNullOrEmpty(board[row][column]) || board[row][column] == " ")
            {
                board[row][column] = playerTurn;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForWin()
        {
            // Your code here
            return HorizontalWin() || VerticalWin() || DiagonalWin();
        }

        public static bool HorizontalWin()
        {
            // Your code here
            return (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn) ||
                (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn) ||
                (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn);
        }
        public static bool VerticalWin()
        {
            // Your code here
            return (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn) ||
                (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn) ||
                (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn);
        }

        public static bool DiagonalWin()
        {
            // Your code here
            return (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn) ||
                (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn);
        }

        public static void DrawBoard()
        {
            var boardInfo = String.Join("|", board[0]);
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
            return;
        }
    }
}
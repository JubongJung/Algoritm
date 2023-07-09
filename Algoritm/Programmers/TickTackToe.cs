using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Programmers
{
    /// <seealso cref="https://school.programmers.co.kr/learn/courses/30/lessons/160585?language=csharp"/>
    public class TickTackToe
    {
        public int IsTickTackToe(string[] stringBoard)
        {
            for(int i =0; i < 3; i++)
            {
                Console.WriteLine($"stringBoard: {stringBoard[i]}");
            }

            char FlagO = 'O';
            char FlagX = 'X';
            char FlagEmpty = '.';

            char[,] board = new char[3, 3];

            for(int i =0;  i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = stringBoard[i][j];
                }
            }

            int CountO = 0;
            int CountX = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j =0; j < 3; j++)
                {
                    if (board[i, j] == FlagO)
                    {
                        CountO++;
                    }
                    else if (board[i, j] == FlagX) 
                    {
                        CountX++; 
                    }
                }
            }

            int bingoO = 0;
            int bingoX = 0;

            for (int i = 0; i < 3; i++)
            {
                string horizontal = "";
                string vertical = "";

                for (int j = 0; j < 3; j++)
                {
                    horizontal += board[i, j];
                }

                for (int j = 0; j < 3; j++)
                {
                    vertical += board[j, i];
                }

                if (vertical == "OOO")
                {
                    Console.WriteLine($"bingo O vertical! {vertical}");
                    bingoO++;
                }
                else if (vertical == "XXX")
                {
                    Console.WriteLine($"bingo X vertical! {vertical}");
                    bingoX++;
                }

                if (horizontal == "OOO")
                {
                    Console.WriteLine($"bingo O horizontal! {horizontal}");
                    bingoO++;
                }
                else if (horizontal == "XXX")
                {
                    Console.WriteLine($"bingo X horizontal! {horizontal}");
                    bingoX++;
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[1, 1] != FlagEmpty)
            {
                if (board[0, 0] == 'O')
                {
                    bingoO++;
                }
                else if (board[0, 0] == 'X')
                {
                    bingoX++;
                }
                Console.WriteLine($"bingo! board 0,0 {board[0, 0]}");
            }

            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[1, 1] != FlagEmpty)
            {
                if (board[2, 0] == 'O')
                {
                    bingoO++;
                }
                else if (board[2, 0] == 'X')
                {
                    bingoX++;
                }
                Console.WriteLine($"bingo! board 2,0 {board[2, 0]}");
            }

            int bingo = bingoO + bingoX;
            Console.WriteLine($"CountO: {CountO}");
            Console.WriteLine($"CountX: {CountX}");
            Console.WriteLine($"bingo O: {bingoO}");
            Console.WriteLine($"bingo X: {bingoX}");
            Console.WriteLine($"bingo  : {bingo}");

            // 1. O보다 X가 많을 경우 0 또는 O와 X의 개수가 2개이상 차이날 경우
            if (CountO < CountX || (CountO - CountX) > 1)
            {
                return 0;
            }

            // 2. O와 X가 동시에 승리하는 경우
            if(bingoO > 0 && bingoX > 0)
            {
                return 0;
            }

            // 3. 빙고가 나왔는데 게임을 진행한 경우
            if(bingoO == 1 && CountO == CountX)
            {
                return 0;
            }

            if(bingoX == 1 && CountO > CountX)
            {
                return 0;
            }

            

            return 1;
        }
    }
}

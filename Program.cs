using System;
using Enums;
using Interfaces;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Board BattleShipBoard=new Board();
            var boardStatus= BattleShipBoard.CreateBoard();
            for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(boardStatus[i,j]);
                    }
                    Console.WriteLine("\n");
                }
        }
    }

    public class Board: IBoard
    {
        public BoardStatus[,] CreateBoard(int rows=10, int columns=10)
        {
            BoardStatus[,] statusBoard = new BoardStatus[rows, columns];
        
            for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        statusBoard[i, j] = BoardStatus.Empty;
                    }
                }

            return statusBoard;
        }
    }




   



}

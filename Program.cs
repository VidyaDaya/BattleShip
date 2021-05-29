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
            // for (int i = 0; i < 10; i++)
            //     {
            //         for (int j = 0; j < 10; j++)
            //         {
            //             Console.Write("{0} ",boardStatus[i,j]);
            //         }
            //         Console.WriteLine("\n");
            //     }
            Ship newShip= new Ship();
            newShip.GetShipDetails(boardStatus);
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

    public class Ship: IShip
    {
        public void GetShipDetails(BoardStatus[,] statusBoard)
        {
            Console.WriteLine("Enter the length of the Ship you want to place in the board");
            int length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where do you want to place the ship? Enter row and column number");
            int row=Convert.ToInt32(Console.ReadLine());
            int column=Convert.ToInt32(Console.ReadLine());
            CreateShip(length,row,column,statusBoard);
        }
        public void CreateShip(int length, int x, int y,BoardStatus[,] statusBoard)
        {
            int counter=1;
            int i=x-1;
           while(counter<=length)
           {
               statusBoard[i,y-1]=BoardStatus.Ship;
               counter++;
               i++;
           }

            for (i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("{0} ",statusBoard[i,j]);
                    }
                    Console.WriteLine("\n");
                }
           
        }
    }




   



}

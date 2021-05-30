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
        
            Ship newShip= new Ship();
            newShip.GetShipDetails(boardStatus);
            BattleShipBoard.CheckResult(boardStatus);
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

        public void CheckResult(BoardStatus[,] statusBoard)
        {
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    if(statusBoard[i,j]==BoardStatus.Ship)
                    {
                        return;
                    }
                }
            }

            Console.WriteLine("You WON!!!");
            Environment.Exit(1);

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
            Console.WriteLine("Do you want it placed horizontally or vertically? (H/V)");
            char direction=Convert.ToChar(Console.ReadLine());
            CreateShip(length,row,column,direction,statusBoard);
        }
        public void CreateShip(int length, int x, int y,char direction,BoardStatus[,] statusBoard)
        {

            int counter=1;
            int i=x-1,j=y-1;
           while(counter<=length)
           {
               if(direction=='V' || direction=='v')
               {
                    statusBoard[i,y-1]=BoardStatus.Ship;
                    counter++;
                    i++;
               }
               else if(direction=='H' || direction=='h')
               {
                   statusBoard[x-1,j]=BoardStatus.Ship;
                    counter++;
                    j++;
               }
                else
               {
                   Console.WriteLine("Sorry! Incorrect input");
                   return;
               }
           }

            for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 10; j++)
                    {
                        Console.Write("{0} ",statusBoard[i,j]);
                    }
                    Console.WriteLine("\n");
                }
           
        }
    }

    public class Attacker: IAttacker
    {

        public AttackOutcome Attack(BoardStatus[,] boardStatus,int x, int y)
        {
            if(boardStatus[x,y]==BoardStatus.Ship)
            {
                boardStatus[x,y]=BoardStatus.Hit;
                return AttackOutcome.Hit;
            }
            else
            {
                boardStatus[x,y]=BoardStatus.Miss;
                return AttackOutcome.Miss;
            }
        }
    }




   



}

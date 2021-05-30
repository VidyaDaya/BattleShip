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
            BattleShipBoard.CreateBoard();
        
            Ship newShip= new Ship();
            newShip.GetShipDetails(BattleShipBoard.boardStatus);
            Attacker attacker= new Attacker();
            attacker.LaunchAttack(BattleShipBoard.boardStatus);
             for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(BattleShipBoard.boardStatus[i, j]);
                    }
                    Console.WriteLine(" ");
                }
            BattleShipBoard.CheckResult();
        }
    }

    public class Board: IBoard
    {
        public BoardStatus[,] boardStatus;

        public void CreateBoard(int rows=10, int columns=10)
        {
           boardStatus = new BoardStatus[rows, columns];
        
            for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        boardStatus[i, j] = BoardStatus.Empty;
                    }
                }

        }

        public void CheckResult()
        {
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    if(boardStatus[i,j]==BoardStatus.Ship)
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

            // for (i = 0; i < 10; i++)
            //     {
            //         for (j = 0; j < 10; j++)
            //         {
            //             Console.Write("{0} ",statusBoard[i,j]);
            //         }
            //         Console.WriteLine("\n");
            //     }
           
        }
    }

    public class Attacker: IAttacker
    {
        public void LaunchAttack(BoardStatus[,] boardStatus)
        {
            Console.WriteLine("Enter the row and column number to launch attack");
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            Attack(boardStatus,x,y);
        }

        private void Attack(BoardStatus[,] boardStatus,int x, int y)
        {
            if(boardStatus[x-1,y-1]==BoardStatus.Ship)
            {
                boardStatus[x-1,y-1]=BoardStatus.Hit;
            }
            else
            {
                boardStatus[x-1,y-1]=BoardStatus.Miss;
            }
        }
    }

}

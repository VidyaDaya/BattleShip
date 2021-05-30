using System;
using Enums;
using Interfaces;

namespace BattleShip
{
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
}
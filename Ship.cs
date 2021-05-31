using System;
using Enums;
using Interfaces;

namespace BattleShip
{
    public class Ship: IShip
    {
        public void GetShipDetails(Board board)
        {
            try
            {
            Console.WriteLine("Enter the length of the Ship you want to place in the board");
            int length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where do you want to place the ship? Enter row and column number");
            int row=Convert.ToInt32(Console.ReadLine());
            int column=Convert.ToInt32(Console.ReadLine());

             if(row>board.rows || column>board.columns || row==0 ||column ==0) 
            {
                 throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("Do you want it placed horizontally or vertically? (H/V)");
            char direction=Convert.ToChar(Console.ReadLine());
            CreateShip(length,row,column,direction,board);
            }
            catch(Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
            
        }
        
        public void CreateShip(int length, int x, int y,char direction,Board board)
        {
            try{
            int counter=1;
            int i=x-1,j=y-1;
           while(counter<=length)
           {
               if((direction=='V' || direction=='v') && (x+length<=board.rows) )
               {
                    board.boardStatus[i,y-1]=BoardStatus.Ship;
                    counter++;
                    i++;
               }
               else if((direction=='H' || direction=='h') && (y+length<=board.columns))
               {
                   board.boardStatus[x-1,j]=BoardStatus.Ship;
                    counter++;
                    j++;
               }
                else
               {
                    throw new ArgumentOutOfRangeException();
               }
           }
            }
            catch(Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
           
        }
    }
}
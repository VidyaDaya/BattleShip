using System;
using Enums;
using Interfaces;

namespace BattleShip
{

     public class Attacker: IAttacker
    {
        public void LaunchAttack(Board board)
        {
            try{
            Console.WriteLine("Enter the row and column number to launch attack");
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            if(x>board.rows || y>board.columns) 
            {
               throw new ArgumentOutOfRangeException();
            }
            Attack(board,x,y);
            }
            catch(Exception exe)
            {
                Console.WriteLine(exe.Message);
            }

        }

        private void Attack(Board board,int x, int y)
        {
            if(board.boardStatus[x-1,y-1]==BoardStatus.Ship)
            {
                board.boardStatus[x-1,y-1]=BoardStatus.Hit;
            }
            else
            {
                board.boardStatus[x-1,y-1]=BoardStatus.Miss;
            }
        }
    }
}
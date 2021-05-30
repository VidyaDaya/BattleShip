using System;
using Enums;
using Interfaces;

namespace BattleShip
{

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
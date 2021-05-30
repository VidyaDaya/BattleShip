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

}

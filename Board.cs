using System;
using Enums;
using Interfaces;

namespace BattleShip{
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
}
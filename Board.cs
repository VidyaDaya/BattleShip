using System;
using Enums;
using Interfaces;

namespace BattleShip
{

public class Board: IBoard
    {
        public BoardStatus[,] boardStatus;

        public int rows;
        public int columns;

        public void CreateBoard(int row=10, int column=10)
        {
            rows=row;
           columns=column;
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
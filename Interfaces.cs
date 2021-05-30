using Enums;

namespace Interfaces{

     public interface IBoard
    {
        public BoardStatus[,] CreateBoard(int rows, int columns);
    }

    public interface IShip
    {
        public void CreateShip(int length, int x, int y,char direction,BoardStatus[,] statusBoard);
    }

    public interface IAttacker
    {
        public AttackOutcome Attack(BoardStatus[,] boardStatus, int x, int y);
    }
}
using Enums;

namespace Interfaces{

     public interface IBoard
    {
        public BoardStatus[,] CreateBoard(int rows, int columns);
    }

    public interface IShip
    {
        public void CreateShip(int length, int x, int y,BoardStatus[,] statusBoard);
    }

    public interface IAttacker
    {
        public AttackOutcome Attack(int x, int y);
    }
}
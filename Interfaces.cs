using Enums;

namespace Interfaces{

     public interface IBoard
    {
        public void CreateBoard(int rows, int columns);
    }

    public interface IShip
    {
        public void CreateShip(int length, int x, int y,char direction,BoardStatus[,] statusBoard);
    }

    public interface IAttacker
    {
        public void LaunchAttack(BoardStatus[,] boardStatus);
    }
}
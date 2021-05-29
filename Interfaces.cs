using Enums;

namespace Interfaces{
     public interface IBoard
    {
        public void CreateBoard(int rows, int columns);
    }

    public interface IShip
    {
        public void CreateShip(int length, int x, int y);
    }

    public interface IAttacker
    {
        public AttackOutcome Attack(int x, int y);
    }
}
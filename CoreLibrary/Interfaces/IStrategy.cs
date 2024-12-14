using CoreLibrary.Entities;

namespace CoreLibrary.Interfaces
{
    public interface IStrategy
    {
        void Execute(Monster attacker, Monster defender);
    }
}

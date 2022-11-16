namespace WarriorGame
{
    internal interface IBattleField
    {
        Avatar GetRandomEnemy(List<Avatar> allAvatars);
        void GoToBatle(Avatar Warrior, Avatar Enemie);
        string WonOrLost(Avatar Warrior, Avatar Enemie);
    }
}
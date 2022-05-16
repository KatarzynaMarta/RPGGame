namespace RPGGame
{
    public interface IMonster
    {
        int Health { get; set; }
        int? RoundsWon { get; }

        void Image();
    }
}
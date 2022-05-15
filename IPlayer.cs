namespace RPGGame
{
    public interface IPlayer
    {
        int Health { get; set; }
        int? RoundsWon { get; }

        void Image();
    }
}
namespace PlayerStats
{
    public class Player
    {
        private float _highScore;
        private int _playedGames;
        private int _wonGames;

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public float HighScore
        {
            get => _highScore;
            set
            {
                if (value > _highScore)
                {
                    _highScore = value;
                }
            }
        }

        public float WinRate => _playedGames == 0 ? 0 : (float)_wonGames / _playedGames;

        public void PlayGame(bool win)
        {
            _playedGames++;

            if (win)
            {
                _wonGames++;
            }
        }
    }
}
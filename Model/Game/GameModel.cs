using System.ComponentModel;
using TMPro;
using UnityEngine;

namespace Model.Game
{
    public class GameModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int playerScore;
        public int PlayerScore
        {
            get => playerScore;

            set
            {
                playerScore = value;
                PlayerScoreTxt
                    .text = value.ToString();
                if (value >= 10)
                {
                    playerScore = 10;
                    Win();
                }
            }
        }

        private int enemyScore;
        public int EnemyScore
        {
            get => enemyScore;

            set
            {
                enemyScore = value;
                EnemyScoreTxt
                    .text = value.ToString();

                if (value >= 10)
                {
                    enemyScore = 10;
                    Lose();
                }
            }
        }

        public TMP_Text PlayerScoreTxt;
        public TMP_Text EnemyScoreTxt;

        private GameObject WinPanel;
        private GameObject LosePanel;

        private TMP_Text WinCoins;
        private TMP_Text LoseCoins;

        public int CurrentWinCoins;

        private bool Stop = false;//TODO
        public GameModel(TMP_Text playerScoreTxt, TMP_Text enemyScoreTxt, GameObject winPanel, GameObject losePanel, TMP_Text winCoins, TMP_Text loseCoins)
        {
            PlayerScoreTxt = playerScoreTxt;
            EnemyScoreTxt = enemyScoreTxt;

            WinPanel = winPanel;
            LosePanel = losePanel;

            WinCoins = winCoins;
            LoseCoins = loseCoins;
        }
        public void Win()
        {
            if (Stop) return;
            WinPanel.SetActive(true);
            var coins = Random.Range(100, 501);
            CurrentWinCoins = coins;
            WinCoins.text = $"+ {coins}";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Win)));
            Stop = true;
        }
        public void Lose()
        {
            if (Stop) return;
            LosePanel.SetActive(true);
            var coins = Random.Range(10, 101);
            CurrentWinCoins = coins;
            LoseCoins.text = $"+ {coins}";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lose)));
            Stop = true;
        }
    }
}

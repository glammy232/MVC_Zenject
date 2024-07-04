using Model.Menu.MenuHome;
using Model.Menu.MenuShop;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using View.Game;
using View.Menu.MenuHome;

namespace GameManager
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        public static GameManager Instance
        {
            get => instance;
            set => instance ??= value;
        }
        public int Win { get => PlayerPrefs.GetInt(nameof(Win), 0); set => PlayerPrefs.SetInt(nameof(Win), value); }
        public int Lose { get => PlayerPrefs.GetInt(nameof(Lose), 0); set => PlayerPrefs.SetInt(nameof(Lose), value); }

        private void Awake() => instance = this;
        [SerializeField] private MenuHomeView MenuHomeView;
        private MenuHomeModel MenuHomeModel;
        [SerializeField] private GameView GameView;
        private const string GameSceneName = "Game";
        public int Level;
        private void Start()
        {
            if (SceneManager.GetActiveScene().buildIndex == 0) InitializeMenuHomeModel();
            if (SceneManager.GetActiveScene().buildIndex == 1) InitializeGameView();
            print("Scene");
            //DontDestroyOnLoad(this);
        }
        private void InitializeMenuHomeModel()
        {
            MenuHomeModel = MenuHomeView.MenuHomeModel;
            MenuHomeModel.PropertyChanged += OnLevelChanged;
        }
        private void InitializeGameView()
        {
            GameView.GameModel.PropertyChanged += OnWinGame;
            GameView.GameModel.PropertyChanged += OnLoseGame;
        }
        public void OnLevelChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MenuHomeModel.CurrentLevel))
            {
                Level = MenuHomeModel.CurrentLevel;
                Debug.Log($"<color=red>{Level}</color>");
                SceneManager.LoadSceneAsync(GameSceneName);
            }
        }
        private void OnWinGame(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(GameView.GameModel.Win))
            {
                print("Win");
                Win++;
                MenuShopModel.Coins += GameView.GameModel.CurrentWinCoins;
            }
        }
        private void OnLoseGame(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(GameView.GameModel.Lose))
            {
                print("Lose");
                Lose++;
                MenuShopModel.Coins += GameView.GameModel.CurrentWinCoins;
            }
        }
        //TODO
        public void Ease()
        {
            Level = 0;
            Debug.Log($"<color=red>{Level}</color>");
            SceneManager.LoadSceneAsync(GameSceneName);
        }
        public void Hard()
        {
            Level = 1;
            Debug.Log($"<color=red>{Level}</color>");
            SceneManager.LoadSceneAsync(GameSceneName);
        }
        public void Impossible()
        {
            Level = 2;
            Debug.Log($"<color=red>{Level}</color>");
            SceneManager.LoadSceneAsync(GameSceneName);
        }
        public void GoMenu()
        {
            SceneManager.LoadSceneAsync("Menu");
        }
    }
}

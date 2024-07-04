using Controller.Game;
using Model.Game;
using TMPro;
using UnityEngine;
using View.Game;
using Zenject;
public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameView GameView;
    [SerializeField] private TMP_Text PlayerScoreTxt;
    [SerializeField] private TMP_Text EnemyScoreTxt;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private TMP_Text WinCoins;
    [SerializeField] private TMP_Text LoseCoins;
    public override void InstallBindings()
    {
        Container
            .Bind<GameController>()
            .AsSingle()
            .WithArguments(new GameModel(PlayerScoreTxt, EnemyScoreTxt, WinPanel, LosePanel, WinCoins, LoseCoins), GameView)
            .NonLazy();
    }
}

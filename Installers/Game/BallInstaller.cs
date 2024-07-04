using Controller.Game.Characters.Enemies.Ball;
using Model.Game.Characters.Enemies.Ball;
using UnityEngine;
using View.Game;
using View.Game.Characters.Enemies.Ball;
using Zenject;

public class BallInstaller : MonoInstaller
{
    [SerializeField] private BallView BallView;
    [SerializeField] private GameView GameView;
    public override void InstallBindings()
    {
        Container
            .Bind<BallController>()
            .AsSingle()
            .WithArguments(new BallModel(), BallView, GameView)
            .NonLazy();
    }
}

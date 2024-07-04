using Controller.Game.Characters.Player;
using Model.Game.Characters.Player;
using UnityEngine;
using View.Game.Characters.Player;
using Zenject;
public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerView PlayerView;
    [SerializeField] private Rigidbody2D Rigidbody2D;
    public override void InstallBindings()
    {
        var playerModel = new PlayerModel(500f, Rigidbody2D);
        Container
            .Bind<PlayerController>()
            .AsSingle()
            .WithArguments(playerModel, PlayerView)
            .NonLazy();
    }
}
using Controller.Menu.MenuTextUpdater;
using Model.Menu.MenuTextUpdater;
using UnityEngine;
using View.Menu.MenuTextUpdater;
using Zenject;
public class MenuTextUpdaterInstaller : MonoInstaller
{
    [SerializeField] private MenuTextUpdaterView MenuTextUpdaterView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuTextUpdaterController>()
            .AsSingle()
            .WithArguments(new MenuTextUpdaterModel(), MenuTextUpdaterView)
            .NonLazy();
    }
}

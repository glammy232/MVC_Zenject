using Controller.Menu.MenuHome;
using Model.Menu.MenuHome;
using UnityEngine;
using View.Menu.MenuHome;
using Zenject;
public class MenuHomeInstaller : MonoInstaller
{
    [SerializeField] private MenuHomeView MenuHomeView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuHomeController>()
            .AsSingle()
            .WithArguments(new MenuHomeModel(), MenuHomeView)
            .NonLazy();
    }
}

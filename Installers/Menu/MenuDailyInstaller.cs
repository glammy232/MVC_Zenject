using Controller.Menu.MenuDaily;
using Model.Menu.MenuDaily;
using UnityEngine;
using View.Menu.MenuDaily;
using Zenject;

public class MenuDailyInstaller : MonoInstaller
{
    [SerializeField] private MenuDailyView MenuDailyView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuDailyController>()
            .AsSingle()
            .WithArguments(new MenuDailyModel(), MenuDailyView)
            .NonLazy();
    }
}

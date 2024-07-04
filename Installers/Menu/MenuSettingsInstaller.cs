using Controller.Menu.MenuSettings;
using Model.Menu.MenuSettings;
using UnityEngine;
using View.Menu.MenuSettings;
using Zenject;

public class MenuSettingsInstaller : MonoInstaller
{
    [SerializeField] private MenuSettingsView MenuSettingsView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuSettingsController>()
            .AsSingle()
            .WithArguments(new MenuSettingsModel(), MenuSettingsView)
            .NonLazy();
    }
}

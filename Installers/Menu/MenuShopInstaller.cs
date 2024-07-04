using Controller.Menu.MenuShop;
using Model.Menu.MenuShop;
using UnityEngine;
using View.Menu.MenuShop;
using Zenject;

public class MenuShopInstaller : MonoInstaller
{
    [SerializeField] private MenuShopView MenuSettingsView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuShopController>()
            .AsSingle()
            .WithArguments(new MenuShopModel(), MenuSettingsView)
            .NonLazy();
    }
}

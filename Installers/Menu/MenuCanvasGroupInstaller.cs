using Controller.Menu.MenuCanvas;
using Model.Menu.MenuCanvas;
using UnityEngine;
using View.Menu.MenuCanvas;
using Zenject;
public class MenuCanvasGroupInstaller : MonoInstaller
{
    [SerializeField] private MenuCanvasView MenuCanvasView;
    public override void InstallBindings()
    {
        Container
            .Bind<MenuCanvasController>()
            .AsSingle()
            .WithArguments(MenuCanvasView, new MenuCanvasModel())
            .NonLazy();
    }
}
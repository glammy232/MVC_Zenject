using Model.Menu.MenuCanvas;
using View.Menu.MenuCanvas;
using Zenject;

namespace Controller.Menu.MenuCanvas
{
    public class MenuCanvasController
    {
        private MenuCanvasModel MenuCanvasModel;
        private MenuCanvasView MenuCanvasView;

        [Inject]
        public MenuCanvasController(MenuCanvasView menuCanvasView, MenuCanvasModel menuCanvasModel)
        {
            MenuCanvasModel = menuCanvasModel;
            MenuCanvasView = menuCanvasView;
            MenuCanvasView.MenuCanvasModel = MenuCanvasModel;

            Enable();

            MenuCanvasModel.SetVisibleCanvasGroup(2);
            MenuCanvasModel.AddListenersOnChangeCanvasGroupButtons(MenuCanvasView.ChangeCanvasGroupButtons);
        }
        private void Enable()
        {
            MenuCanvasModel.ChangedVisibleCanvasGroup += ChangeVisibleCanvasGroup;
        }

        private void ChangeVisibleCanvasGroup(int index)
        {
            MenuCanvasView.ChangeVisibleCanvasGroup(index);
        }
        private void Disable()
        {
            MenuCanvasModel.ChangedVisibleCanvasGroup -= ChangeVisibleCanvasGroup;
        }
    }
}

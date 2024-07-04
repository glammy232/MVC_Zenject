using Model.Menu.MenuTextUpdater;
using View.Menu.MenuTextUpdater;

namespace Controller.Menu.MenuTextUpdater
{
    public class MenuTextUpdaterController
    {
        private MenuTextUpdaterModel MenuTextUpdaterModel;
        private MenuTextUpdaterView MenuTextUpdaterView;

        public MenuTextUpdaterController(MenuTextUpdaterModel menuTextUpdaterModel, MenuTextUpdaterView menuTextUpdaterView)
        {
            MenuTextUpdaterModel = menuTextUpdaterModel;
            MenuTextUpdaterView = menuTextUpdaterView;

            MenuTextUpdaterView.MenuTextUpdaterModel = MenuTextUpdaterModel;
        }
    }
}

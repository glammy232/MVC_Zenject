using Model.Menu.MenuHome;
using View.Menu.MenuHome;

namespace Controller.Menu.MenuHome
{
    public class MenuHomeController
    {
        private MenuHomeModel menuHomeModel;
        public MenuHomeModel MenuHomeModel
        {
            get => menuHomeModel;

            set => menuHomeModel ??= value;
        }

        private MenuHomeView MenuHomeView;
        public MenuHomeController(MenuHomeModel menuHomeModel, MenuHomeView menuHomeView)
        {
            MenuHomeModel = menuHomeModel;
            MenuHomeView = menuHomeView;

            MenuHomeView.MenuHomeModel = MenuHomeModel;

            MenuHomeModel.AddListenersOnButtons(MenuHomeView.ChooseGameLevelButtons);
        }
    }
}

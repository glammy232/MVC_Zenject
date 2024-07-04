using Model.Menu.MenuDaily;
using View.Menu.MenuDaily;

namespace Controller.Menu.MenuDaily
{
    public class MenuDailyController
    {
        private MenuDailyModel MenuDailyModel;
        private MenuDailyView MenuDailyView;

        public MenuDailyController(MenuDailyModel menuDailyModel, MenuDailyView menuDailyView)
        {
            MenuDailyModel = menuDailyModel;
            MenuDailyView = menuDailyView;
            MenuDailyView.MenuDailyModel = menuDailyModel;
        }
    }
}

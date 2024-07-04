using Model.Menu.MenuSettings;
using View.Menu.MenuSettings;

namespace Controller.Menu.MenuSettings
{
    public class MenuSettingsController
    {
        private MenuSettingsModel MenuSettingsModel;
        private MenuSettingsView MenuSettingsView;
        public MenuSettingsController(MenuSettingsModel menuSettingsModel, MenuSettingsView menuSettingsView)
        {
            MenuSettingsModel = menuSettingsModel;
            MenuSettingsView = menuSettingsView;

            MenuSettingsView.MenuSettingsModel = menuSettingsModel;
        }
    }
}

using Model.Menu.MenuShop;
using View.Menu.MenuShop;

namespace Controller.Menu.MenuShop
{
    public class MenuShopController
    {
        private MenuShopModel MenuShopModel;
        private MenuShopView MenuShopView;
        public MenuShopController(MenuShopModel menuShopModel, MenuShopView menuShopView)
        {
            MenuShopModel = menuShopModel;
            MenuShopView = menuShopView;

            MenuShopModel.ShopItemsView = MenuShopView.ShopItemsView;

            MenuShopModel.ShopItemBuyPanels = MenuShopView.ShopItemBuyPanels;

            MenuShopModel.OpenBuyPanelButtons = MenuShopView.OpenBuyPanelButtons;
            MenuShopModel.CloseBuyPanelButtons = MenuShopView.CloseBuyPanelButtons;
            MenuShopModel.BuyShopItemButtons = MenuShopView.BuyShopItemButtons;

            MenuShopModel.InitializeShopItems();
        }
    }
}

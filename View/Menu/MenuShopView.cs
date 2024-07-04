using Model.Menu.MenuShop;
using UnityEngine;
using UnityEngine.UI;

namespace View.Menu.MenuShop
{
    public class MenuShopView : MonoBehaviour
    {
        private MenuShopModel menuShopModel;
        public MenuShopModel MenuShopModel
        {
            get => menuShopModel;
            set => menuShopModel ??= value;
        }

        public Button[] OpenBuyPanelButtons;
        public Button[] CloseBuyPanelButtons;
        public Button[] BuyShopItemButtons;

        public GameObject[] ShopItemsView;

        public GameObject[] ShopItemBuyPanels;
    }
}

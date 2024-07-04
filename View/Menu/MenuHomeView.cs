using Model.Menu.MenuHome;
using UnityEngine;
using UnityEngine.UI;

namespace View.Menu.MenuHome
{
    public class MenuHomeView : MonoBehaviour
    {
        private MenuHomeModel menuHomeMode;
        public MenuHomeModel MenuHomeModel
        {
            get => menuHomeMode;
            set => menuHomeMode ??= value;
        }
        public Button[] ChooseGameLevelButtons;
    }
}

using Model.Menu.MenuShop;
using Model.Menu.MenuTextUpdater;
using System.ComponentModel;
using TMPro;
using UnityEngine;

namespace View.Menu.MenuTextUpdater
{
    public class MenuTextUpdaterView : MonoBehaviour
    {
        public MenuTextUpdaterModel MenuTextUpdaterModel = new MenuTextUpdaterModel(); //TODO 

        [SerializeField] private TMP_Text CoinsTxt;
        [SerializeField] private TMP_Text WinTxt;
        [SerializeField] private TMP_Text LoseTxt;

        private void Start()
        {

            CoinsTxt.text = MenuShopModel.Coins.ToString();
            WinTxt.text = $"Win: {MenuTextUpdaterModel.Win}";
            LoseTxt.text = $"Lose: {MenuTextUpdaterModel.Lose}";

            MenuTextUpdaterModel.PropertyChanged += OnWinValueChanged;
            MenuTextUpdaterModel.PropertyChanged += OnLoseValueChanged;
        }
        private void OnWinValueChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MenuTextUpdaterModel.Win)) WinTxt.text = $"Win: {MenuTextUpdaterModel.Win}";
        }
        private void OnLoseValueChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MenuTextUpdaterModel.Lose)) WinTxt.text = $"Win: {MenuTextUpdaterModel.Lose}";
        }
    }
}

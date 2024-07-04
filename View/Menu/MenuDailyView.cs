using Model.Menu.MenuDaily;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace View.Menu.MenuDaily
{
    public class MenuDailyView : MonoBehaviour
    {
        public MenuDailyModel MenuDailyModel;

        public Button[] DailyItemButtons = new Button[7];
        public TMP_Text DailyItemTimerTxt;

        private void OnEnable()
        {
            MenuDailyModel = new MenuDailyModel();
            DailyItemButtons[0].onClick.AddListener(MenuDailyModel.GetCoins);
            StartCoroutine(SetDailyItemTimer());
        }
        IEnumerator SetDailyItemTimer()
        {
            Debug.Log(DailyItemTimerTxt.name);
            Debug.Log(MenuDailyModel);
            Debug.Log(MenuDailyModel.DailyItemTimer.ClaimTime());
            DailyItemTimerTxt.text = MenuDailyModel.DailyItemTimer.ClaimTime();
            yield return new WaitForSeconds(1);
            StartCoroutine(SetDailyItemTimer());
        }
    }
}

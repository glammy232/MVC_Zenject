using Model.Menu.MenuSettings;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace View.Menu.MenuSettings
{
    public class MenuSettingsView : MonoBehaviour
    {
        private MenuSettingsModel menuSettingsModel;
        public MenuSettingsModel MenuSettingsModel
        {
            get => menuSettingsModel;
            set => menuSettingsModel ??= value;
        }

        [SerializeField] private Button SwitchVibration;
        private void Start()
        {
            SwitchVibration.onClick.AddListener(MenuSettingsModel.SetVibration);
            MenuSettingsModel.PropertyChanged += OnVibrationChanged;
            SetSwitchRotation(MenuSettingsModel.Vibration);
        }
        public void SetSwitchRotation(int value)
        {
            SwitchVibration.transform.rotation = Quaternion.Euler(0, 0, 180 * (value - 1));
            if (value == 0) SwitchVibration.image.color = Color.gray;
            else if (value == 1) SwitchVibration.image.color = Color.white;
        }
        private void OnVibrationChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MenuSettingsModel.Vibration))
                SetSwitchRotation(MenuSettingsModel.Vibration);
        }
    }
}

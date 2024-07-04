using Model.Menu.MenuCanvas;
using UnityEngine;
using UnityEngine.UI;

namespace View.Menu.MenuCanvas
{
    public class MenuCanvasView : MonoBehaviour
    {
        private MenuCanvasModel menuCanvasModel;
        public MenuCanvasModel MenuCanvasModel
        {
            get => menuCanvasModel;

            set
            {
                menuCanvasModel = value switch
                {
                    null => throw new System.NullReferenceException(),
                    _ => value
                };
            }
        }

        [SerializeField] private CanvasGroup[] CanvasGroups;
        public Button[] ChangeCanvasGroupButtons;

        public void ChangeVisibleCanvasGroup(int index)
        {
            for (int i = 0; i < CanvasGroups.Length; i++)
            {
                if (i != index) MakeInvisibleCanvasGroup(CanvasGroups[i]);
                else MakeVisibleCanvasGroup(CanvasGroups[i]);
            }
        }
        private void MakeVisibleCanvasGroup(CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
        private void MakeInvisibleCanvasGroup(CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
    }
}

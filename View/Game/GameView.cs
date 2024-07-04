using Model.Game;
using System.Collections;
using TMPro;
using UnityEngine;

namespace View.Game
{
    public class GameView : MonoBehaviour
    {
        public GameModel GameModel;

        private void Start()
        {
            StartCoroutine(SetScoreTexts());
        }
        IEnumerator SetScoreTexts()
        {
            SetScoreText(GameModel.PlayerScoreTxt, GameModel.PlayerScore);
            SetScoreText(GameModel.EnemyScoreTxt, GameModel.EnemyScore);
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(SetScoreTexts());
        }
        private void SetScoreText(TMP_Text txt, int value)
        {
            txt.text = value.ToString();
        }
    }
}

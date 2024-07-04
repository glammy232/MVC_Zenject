using Model.Game.Characters.Enemies.Ball;
using UnityEngine;

namespace View.Game.Characters.Enemies.Ball
{
    public class BallView : MonoBehaviour
    {
        public BallModel BallModel;
        public GameView GameView;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.name == "PlayerGate")
            {
                GameView.GameModel.EnemyScore++;
            }
            if (collision.collider.name == "EnemyGate")
            {
                GameView.GameModel.PlayerScore++;
            }
        }
    }
}

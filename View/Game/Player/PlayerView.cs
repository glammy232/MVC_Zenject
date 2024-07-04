using Model.Game.Characters.Player;
using UnityEngine;
using View.Game.Characters.Enemies.Ball;

namespace View.Game.Characters.Player
{
    public sealed class PlayerView : MonoBehaviour
    {
        public PlayerModel PlayerModel;

        private void FixedUpdate()
        {
            Move(PlayerModel.MousePosition() - (Vector2)transform.position);
        }
        private void Move(Vector2 direction)
        {
            PlayerModel.Rigidbody2D.velocity = Vector2.Lerp(transform.position, direction, PlayerModel.Speed * 500f * Time.fixedDeltaTime);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out BallView ball))
            {
                ball.GetComponent<Rigidbody2D>().AddForce(PlayerModel.Rigidbody2D.velocity, ForceMode2D.Impulse);
            }
        }
    }
}

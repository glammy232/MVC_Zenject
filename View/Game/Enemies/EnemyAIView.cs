using Model.Game.Characters.Enemies.EnemyAI;
using UnityEngine;
using View.Game.Characters.Enemies.Ball;

namespace View.Game.Characters.Enemies.EnemyAI
{
    public sealed class EnemyAIView : MonoBehaviour
    {
        public EnemyAIModel EnemyAIModel;

        public void Start()
        {
            EnemyAIModel.EnemyAISpriteRenderer.sprite = EnemyAIModel.EnemyAISprites[EnemyAIModel.Level];
        }
        private void FixedUpdate()
        {
            if (EnemyAIModel.IsColdownComplete) Move(EnemyAIModel.TargetBall.transform.position - transform.position);
            else if (!EnemyAIModel.IsColdownComplete) Move(EnemyAIModel.ReturnPoint - (Vector2)transform.position);
        }
        public void Move(Vector2 direction)
        {
            EnemyAIModel.Rigidbody2D.AddForce(direction * EnemyAIModel.Speed, ForceMode2D.Force);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out BallView ball))
            {
                Debug.Log("Ball Collision");

                ball.GetComponent<Rigidbody2D>().AddForce(EnemyAIModel.Rigidbody2D.velocity, ForceMode2D.Impulse);
                StartCoroutine(EnemyAIModel.StartColdown());
            }
        }
    }
}

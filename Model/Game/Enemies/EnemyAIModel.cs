using System.Collections;
using UnityEngine;

namespace Model.Game.Characters.Enemies.EnemyAI
{
    public class EnemyAIModel
    {
        public Rigidbody2D Rigidbody2D;
        public GameObject TargetBall;
        public SpriteRenderer EnemyAISpriteRenderer;
        public Sprite[] EnemyAISprites;
        public float Speed;
        public int Level;

        //RealTime
        public Vector2 ReturnPoint = new Vector2(0, 2.65f);
        public bool IsColdownComplete = true;
        public EnemyAIModel(int level, GameObject targetBall, Sprite[] enemyAISprite, SpriteRenderer enemyAISpriteRenderer, Rigidbody2D rigidbody2D)
        {
            Rigidbody2D = rigidbody2D;
            Level = level;
            TargetBall = targetBall;
            EnemyAISprites = enemyAISprite;
            EnemyAISpriteRenderer = enemyAISpriteRenderer;

            if (Level == 0) Speed = 100f;
            else if (Level == 1) Speed = 150f;
            else if (Level == 2) Speed = 250f;
        }
        public IEnumerator StartColdown()
        {
            IsColdownComplete = false;
            yield return new WaitForSeconds(5f);
            IsColdownComplete = true;
        }
    }
}

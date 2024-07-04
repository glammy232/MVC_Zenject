using Controller.Game.Characters.Enemies.EnemyAI;
using Model.Game.Characters.Enemies.EnemyAI;
using UnityEngine;
using View.Game.Characters.Enemies.EnemyAI;
using Zenject;
public class EnemyAIInstaller : MonoInstaller
{
    [SerializeField] private Rigidbody2D Rigidbody2D;
    [SerializeField] private EnemyAIView EnemyAIView;
    [SerializeField] private GameObject TargetBall;
    [SerializeField] private Sprite[] EnemyAISprites;
    [SerializeField] private SpriteRenderer EnemyAISpriteRenderer;
    public override void InstallBindings()
    {
        var enemyAIModel = new EnemyAIModel(GameManager.GameManager.Instance.Level, TargetBall, EnemyAISprites, EnemyAISpriteRenderer, Rigidbody2D);

        Container
            .Bind<EnemyAIController>()
            .AsSingle()
            .WithArguments(enemyAIModel, EnemyAIView)
            .NonLazy();
    }
}
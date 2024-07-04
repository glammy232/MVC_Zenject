using Model.Game.Characters.Enemies.EnemyAI;
using UnityEngine;
using View.Game.Characters.Enemies.EnemyAI;

namespace Controller.Game.Characters.Enemies.EnemyAI
{
    public class EnemyAIController
    {
        private EnemyAIModel EnemyAIModel;
        private EnemyAIView EnemyAIView;
        public EnemyAIController(EnemyAIModel enemyAiModel, EnemyAIView enemyAIView)
        {
            EnemyAIModel = enemyAiModel;
            EnemyAIView = enemyAIView;
            Debug.Log(EnemyAIModel.Level);

            EnemyAIView.EnemyAIModel = EnemyAIModel;
        }
    }
}

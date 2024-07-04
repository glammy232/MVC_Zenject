using Model.Game.Characters.Enemies.Ball;
using View.Game;
using View.Game.Characters.Enemies.Ball;

namespace Controller.Game.Characters.Enemies.Ball
{
    public class BallController
    {
        private BallModel BallModel;
        private BallView BallView;
        public BallController(BallModel ballModel, BallView ballView, GameView gameView)
        {
            BallModel = ballModel;
            BallView = ballView;

            BallView.BallModel = ballModel;
            BallView.GameView = gameView;
        }
    }
}

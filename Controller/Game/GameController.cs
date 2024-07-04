using Model.Game;
using View.Game;

namespace Controller.Game
{
    public class GameController
    {
        private GameModel GameModel;
        private GameView GameView;

        public GameController(GameModel gameModel, GameView gameView)
        {
            GameModel = gameModel;
            GameView = gameView;

            GameView.GameModel = gameModel;
        }
    }
}

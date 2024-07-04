using Model.Game.Characters.Player;
using View.Game.Characters.Player;

namespace Controller.Game.Characters.Player
{
    public class PlayerController
    {
        private PlayerModel PlayerModel;
        private PlayerView PlayerView;
        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            PlayerModel = playerModel;
            PlayerView = playerView;

            PlayerView.PlayerModel = PlayerModel;
        }
    }
}


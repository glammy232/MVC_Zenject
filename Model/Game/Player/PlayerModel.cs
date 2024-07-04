using UnityEngine;

namespace Model.Game.Characters.Player
{
    public class PlayerModel
    {
        public Rigidbody2D Rigidbody2D;
        public float Speed;
        public Vector2 MousePosition() => Camera.main.ScreenToWorldPoint(Input.mousePosition);

        public PlayerModel(float speed, Rigidbody2D rigidbody2D)
        {
            Rigidbody2D = rigidbody2D;
            Speed = speed + PlayerPrefs.GetInt("IsOpen2") * 25f + PlayerPrefs.GetInt("IsOpen3") * 25f;
        }
    }
}


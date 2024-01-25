using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Player
    {
        private const float PLAYER_SPEED = 4f;
        private Sprite _sprite;

        public Player()
        {
            _sprite = new Sprite();
            _sprite.Texture = TextureManager.PlayerTexture;

            var spriteSize = new Vector2f(_sprite.TextureRect.Width, _sprite.TextureRect.Height);
            var screenCenter = new Vector2f(Game.WIDTH / 2f, Game.HEIGHT / 2f);
            var startPosition = screenCenter - spriteSize / 2f;

            _sprite.Position = startPosition;
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(_sprite);
        }

        private void Move()
        {
            bool shouldMoveLeft = Keyboard.IsKeyPressed(Keyboard.Key.A);
            bool shouldMoveRight = Keyboard.IsKeyPressed(Keyboard.Key.D);
            bool shouldMoveUp = Keyboard.IsKeyPressed(Keyboard.Key.W);
            bool shouldMoveDown = Keyboard.IsKeyPressed(Keyboard.Key.S);

            bool shouldMove = shouldMoveLeft || shouldMoveRight || shouldMoveUp || shouldMoveDown;

            if (!shouldMove)
            {
                return;
            }

            var position = _sprite.Position;

            if (shouldMoveLeft)
            {
                position.X -= PLAYER_SPEED;
            }

            if (shouldMoveRight)
            {
                position.X += PLAYER_SPEED;
            }

            if (shouldMoveUp)
            {
                position.Y -= PLAYER_SPEED;
            }

            if (shouldMoveDown)
            {
                position.Y += PLAYER_SPEED;
            }

            _sprite.Position = position;
        }

        public void Update()
        {
            Move();
        }


    }
}

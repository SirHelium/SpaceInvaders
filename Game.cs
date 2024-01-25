using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Game
    {
        public const int WIDTH = 640;
        public const int HEIGHT = 480;

        private const string TITLE = "Space Invaders";
        private RenderWindow _window;
        private Sprite _background;
        private Player _player;

        public Game()
        {
            var mode = new VideoMode(WIDTH, HEIGHT);
            _window = new RenderWindow(mode, TITLE);

            _window.SetVerticalSyncEnabled(true);
            _window.Closed += (_, _) => _window.Close();

            _background = new Sprite();
            _background.Texture = TextureManager.BackgroundTexture;

            _player = new Player();
        }

        public void Run()
        {
            while (_window.IsOpen)
            {
                HandleEvents();
                Update();
                Draw();
            }
               
        }

        private void HandleEvents()
        {
            _window.DispatchEvents();
        }

        private void Update()
        {
            _player.Update();
        }

        private void Draw()
        {
            _window.Draw(_background);
            _player.Draw(_window);
            _window.Display();
        }
    }
}

using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public static class TextureManager
    {
        private const string ASSETS_PATH = "D:\\Proekty\\Space Invaders\\Assets\\";
        private const string BACKGROUND_TEXTURE_PATH = "Assets\\Backgrounds\\greenBG.png";
        private const string PLAYER_TEXTURE_PATH = "Assets\\Ships\\playerShip3_green.png";

        public static Texture BackgroundTexture;
        public static Texture PlayerTexture;

         static TextureManager()
        {
            BackgroundTexture = new Texture(ASSETS_PATH + BACKGROUND_TEXTURE_PATH);
            PlayerTexture = new Texture(ASSETS_PATH + PLAYER_TEXTURE_PATH);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace EMProcess
{
    class Buttons
    {
        public Vector2 Pos;
        public String NameButton;
        public Texture2D Texture;
        private SpriteBatch spriteBatch;
        public Color Color;

        //Constructor for buttons
        public Buttons(Texture2D texture, String name, Vector2 pos, SpriteBatch sb, Color color)
        {
            Pos = pos;
            NameButton = name;
            Texture = texture;
            spriteBatch = sb;
            Color = color;
        }

        public void ChangeColor(Color color)
        {
            Color = color;
        }

        public void Draw()
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, Pos, Color);
            spriteBatch.End();
        }
    }
}

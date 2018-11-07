using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace EMProcess
{
    class Physic
    {
        
    }

    class MenuPhysics
    {

        public MenuPhysics()
        {

        }

        public bool CheckCollision(Texture2D button, int hegthMouse, int widthMouse, Vector2 buttonPos, Vector2 mousePos, float Scale)
        {
            BoundingBox boundingBoxButton;
            BoundingBox boundingBoxMouse;

            boundingBoxButton.Max = new Vector3(buttonPos.X + button.Width * Scale, buttonPos.Y + button.Height * Scale, 0);
            boundingBoxButton.Min = new Vector3(buttonPos.X, buttonPos.Y, 0);
            boundingBoxMouse.Max = new Vector3(mousePos.X + widthMouse, mousePos.Y + hegthMouse / 4, 0);
            boundingBoxMouse.Min = new Vector3(mousePos.X, mousePos.Y, 0);

            if (boundingBoxMouse.Intersects(boundingBoxButton))
                return true;
            return false;
        }

        public bool CheckCollision(Texture2D button, Texture2D mouse, Vector2 buttonPos, Vector2 mousePos, float Scale)
        {
            BoundingBox boundingBoxButton;
            BoundingBox boundingBoxMouse;

            boundingBoxButton.Max = new Vector3(buttonPos.X + button.Width * Scale, buttonPos.Y + button.Height * Scale, 0);
            boundingBoxButton.Min = new Vector3(buttonPos.X, buttonPos.Y, 0);
            boundingBoxMouse.Max = new Vector3(mousePos.X + mouse.Width, mousePos.Y + mouse.Height / 4, 0);
            boundingBoxMouse.Min = new Vector3(mousePos.X, mousePos.Y, 0);

            if (boundingBoxMouse.Intersects(boundingBoxButton))
                return true;
            return false;
        }

    }
}

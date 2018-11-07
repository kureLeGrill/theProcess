using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EMProcess
{
    class MainMenu
    {
        List<Buttons> buttonList = new List<Buttons>();
        MenuPhysics physicMainMenu = new MenuPhysics();

        //Constructor for main menu
        public MainMenu(ContentManager content, SpriteBatch spriteBatch)
        {
            buttonList.Add(new Buttons(content.Load<Texture2D>(@"MenuButtons/Start_mk2"),"Start",new Vector2(200,200),spriteBatch,Color.White));
            buttonList.Add(new Buttons(content.Load<Texture2D>(@"MenuButtons/Option_mk2"), "Options", new Vector2(200, 400), spriteBatch, Color.White));
            buttonList.Add(new Buttons(content.Load<Texture2D>(@"MenuButtons/Exit_mk2"),"Exit", new Vector2(200, 600), spriteBatch, Color.White));

        }

        public void UpdateMainMenu(MouseState mouse)
        {
            foreach (Buttons button in buttonList)
            {

                if(physicMainMenu.CheckCollision(button.Texture, 20, 20, button.Pos, new Vector2(mouse.X,mouse.Y), 1 ))
                {
                    button.ChangeColor(Color.Red);
                }
                else
                {
                    button.ChangeColor(Color.White);
                }
            }
        }

        public void DrawMainMenu(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach (Buttons button in buttonList)
            {
                spriteBatch.Draw(button.Texture, button.Pos, button.Color);
                
            }
            spriteBatch.End();
        }
    }
}

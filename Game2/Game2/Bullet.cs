using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Bullet
    {
        public Texture2D texture;
        public Vector2 orign;
        public Vector2 position;
        public bool isVisible;
        public float speed;

        //Constructor
        public Bullet(Texture2D newTrexture)
        {
            speed = 10;
            texture = newTrexture;
            isVisible = false;
        }

        //Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}

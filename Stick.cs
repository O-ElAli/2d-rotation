using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace _2d_rotation
{
    public class Stick{


        public float center = 200;
        public float x;
        public float y;
        private GameTime gameTime;
        public int time;

        public float angle = 100;

        public void update()
        {
            angle += (float)0.01;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            x = 200+(float)(200 * Math.Cos(angle));
            y = 200+(float)(200 * Math.Sin(angle));

            spriteBatch.DrawLine(200, 200, x, y, Color.Red, 5f);
            
        }
    }
}

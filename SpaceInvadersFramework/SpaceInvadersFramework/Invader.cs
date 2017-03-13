using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Invader : SpriteGameObject
    {
        private int speed = 300;

        public Invader(string assetname, int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Velocity = new Vector2(speed, 0);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);           

            if (this.position.X < 0)
            {
                this.position = new Vector2(0, position.Y + 32);
                this.Velocity *= -1;
            }

            if (this.position.X + this.sprite.Width > 800)
            {                
                this.position = new Vector2(800 - this.sprite.Width, position.Y + 32);
                this.Velocity *= -1;
            }
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        private int speed = 400;

        public Player(): base("ship")
        {
            
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            //base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Left) || this.position.X + this.sprite.Width > 800)
                this.Velocity = new Vector2(-speed, 0);
            else this.Velocity = Vector2.Zero;
            if (inputHelper.IsKeyDown(Keys.Right) || this.position.X < 0)
                this.Velocity = new Vector2(speed, 0);

            
        }
    }
}

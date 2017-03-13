using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        public Player(): base("ship")
        {

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            //base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Left))
                this.position.X -= 5;
            if (inputHelper.IsKeyDown(Keys.Right))
                this.position.X += 5;

            
        }
    }
}

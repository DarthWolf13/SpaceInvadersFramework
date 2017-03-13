using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvadersFramework
{
    class TitleScreenState : GameObjectList
    {
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
                SpaceInvaders.GameStateManager.SwitchTo("PlayingState");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            

        }
    }
}

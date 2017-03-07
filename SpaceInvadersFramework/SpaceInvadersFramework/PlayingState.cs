using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        private SpriteGameObject player;

        public PlayingState()
        {
            player = new SpriteGameObject("ship");

            this.Add(new SpriteGameObject("background"));
            this.Add(player);

        }
    }
}

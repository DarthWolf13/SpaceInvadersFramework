using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            Player player = new Player();
            player.Position = new Vector2(380, 580);

            this.Add(new SpriteGameObject("background"));
            this.Add(player);

        }
    }
}

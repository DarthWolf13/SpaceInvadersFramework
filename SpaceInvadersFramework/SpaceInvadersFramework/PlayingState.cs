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
        private GameObjectList invaders;

        public PlayingState()
        {
            Player player = new Player();
            player.Position = new Vector2(380, 580);

            invaders = new GameObjectList();
            invaders.Position = new Vector2(0, 0);
            Invader redInvader = new Invader("red_invader");
            invaders.Add(redInvader);

            this.Add(new SpriteGameObject("background"));
            this.Add(player);
            this.Add(invaders);
        }
    }
}

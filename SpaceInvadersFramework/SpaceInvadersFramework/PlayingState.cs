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

            this.Add(new SpriteGameObject("background"));
            this.Add(player);
            this.Add(invaders);

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i * 98, 0, "blue_invader"));
                this.invaders.Add(new Invader(i * 98, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i * 98, 128, "red_invader"));
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            
        }

    }
}

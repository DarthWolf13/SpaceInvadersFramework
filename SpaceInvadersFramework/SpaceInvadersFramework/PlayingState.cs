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
        private GameObjectList bullet;
        Player player;

        internal Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public PlayingState()
        {
            player = new Player();
            player.Position = new Vector2(380, 580);

            invaders = new GameObjectList();
            invaders.Position = new Vector2(0, 0);

            bullet = new GameObjectList();

            this.Add(new SpriteGameObject("background"));           
            this.Add(invaders);
            this.Add(bullet);
            this.Add(player);

            for (int i = 0; i < 9; i++)
            {
                this.invaders.Add(new Invader(i * 98, 0, "blue_invader"));
                this.invaders.Add(new Invader(i * 98, 64, "yellow_invader"));
                this.invaders.Add(new Invader(i * 98, 128, "red_invader"));
            }
        }
            public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
                this.bullet.Add(new Bullet(player.Position.X, player.Position.Y));
        }
    }
}

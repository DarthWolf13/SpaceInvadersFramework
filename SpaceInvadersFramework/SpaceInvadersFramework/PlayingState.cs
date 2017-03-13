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
        private GameObjectList bullets;
        Player player;
        Score score;

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

            bullets = new GameObjectList();

            score = new Score();

            this.Add(new SpriteGameObject("background"));           
            this.Add(invaders);
            this.Add(bullets);
            this.Add(player);
            this.Add(score);

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
                this.bullets.Add(new Bullet(player.Position.X, player.Position.Y));
            }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach (Invader invader in invaders.Objects)                
            {
                foreach (Bullet bullet in bullets.Objects)
                {
                    if (bullet.CollidesWith(invader)) {
                        bullet.Visible = false;
                        invader.Visible = false;
                        score.ScoreValue += 10;
                    }
                }

            }

            
        }
    }
}

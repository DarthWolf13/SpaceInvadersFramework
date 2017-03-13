using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Bullet : SpriteGameObject
    {
        public Bullet () : base("bullet")
        {
            PlayingState PS = GameWorld as PlayingState;
            this.Position = PS.Player.Position;
        }

        public Bullet(float x, float y) : base("bullet")
        {
            this.Position = new Vector2(x, y);
            this.Velocity = new Vector2(0, -300);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        SpriteSheet ship;

        public Player(string shipAssetName):base("")
        {
            ship = new SpriteSheet(shipAssetName);

            
        }
    }
}

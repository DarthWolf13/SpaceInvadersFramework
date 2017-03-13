using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Invader : SpriteGameObject
    {
        public Invader(string assetname, int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
        }
    }
}

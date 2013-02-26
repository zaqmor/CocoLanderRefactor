using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander.Graphics
{
    public class TextureAsset2
    {
        public readonly string AssetName;
        public Texture2D Texture { get; protected set; }

        public TextureAsset2(string assetName)
        {
            AssetName = assetName;
        }

        public void LoadContent(ContentManager contentManager)
        {
            Texture =
                Texture ??
                contentManager.Load<Texture2D>(AssetName);
        }
    }
}

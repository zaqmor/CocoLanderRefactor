using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander
{
    public class TextureAsset
    {
        public readonly string AssetName;

        public Texture2D Texture { get; protected set; }

        public TextureAsset(string assetName)
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

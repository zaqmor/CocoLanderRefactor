using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocoLander;
using CocoLander.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace CocoLander.Graphics
{
    public class TargetGraphic2 : IGraphic
    {
        public TextureAsset2 TextureAsset { get; protected set; }

        public int Width { get { return TextureAsset.Texture.Width; } }
        public int Height { get { return TextureAsset.Texture.Height; } }
        public Color DefaultTint { get { return Color.White; } }

        public TargetGraphic2()
        {
            TextureAsset = TextureAssets.TargetTextureAsset;
        }

        public void LoadContent(ContentManager contentManager)
        {
            TextureAsset.LoadContent(contentManager);
        }

        public Vector2 CenteredOrigin { get; protected set; }
    }
}

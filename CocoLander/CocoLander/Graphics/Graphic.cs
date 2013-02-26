using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace CocoLander
{
    public abstract class Graphic
    {
        protected static TextureAsset _TextureAsset { get; set; }
        public TextureAsset TextureAsset { get { return _TextureAsset; } }

        public int Width { get { return TextureAsset.Texture.Width; } }
        public int Height { get { return TextureAsset.Texture.Height; } }
        public Color DefaultTint { get; set; }

        protected Graphic(string assetName)
        {
            _TextureAsset = new TextureAsset(assetName);
            DefaultTint = Color.White;
        }

        public static void LoadContent(ContentManager contentManager)
        {
            _TextureAsset.LoadContent(contentManager);
        }

        public Vector2 CenteredOrigin
        {
            get
            {
                return new Vector2(Width / 2.0f, Height / 2.0f);
            }
        }
    }
}

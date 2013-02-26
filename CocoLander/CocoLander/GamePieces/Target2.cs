using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocoLander.Graphics;
using CocoLander.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander.GamePieces
{
    public class Target2 : IDrawable2
    {
        public IGraphic Graphic { get; protected set; }

        public Vector2 Position { get; set; }
        public Rectangle SourceRectangle { get; protected set; }
        public Color Tint { get; protected set; }
        public float Rotation { get; protected set; }
        public float Scale { get; protected set; }
        public SpriteEffects SpriteEffects { get; protected set; }
        public float LayerDepth { get; protected set; }
        public Color TextureColor { get; set; }

        public Target2()
        {
            Graphic = new TargetGraphic2();

            Position = new Vector2();
            TextureColor = Color.White;
        }

        public Vector2 ScreenOrigin
        {
            get
            {
                return new Vector2(Graphic.Width / 2.0f, Graphic.Height / 2.0f);
            }
        }

        public void LoadContent(ContentManager contentManager)
        {
            Graphic.LoadContent(contentManager);
        }
    }
}

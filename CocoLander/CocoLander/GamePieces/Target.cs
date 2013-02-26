using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander
{
    public class Target
    {
        public TargetGraphic Graphic { get; protected set; }

        public Vector2 Position { get; set; }
        public Color TextureColor { get; set; }

        public Target()
        {
            Graphic = new TargetGraphic();

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

        public static void LoadContent(ContentManager contentManager)
        {
            TargetGraphic.LoadContent(contentManager);
        }
    }
}

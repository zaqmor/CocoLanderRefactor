using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocoLander.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander
{
    public static class SpriteBatchMixins
    {
        public static void DrawBasic(this SpriteBatch spriteBatch, CocoLander cocoLander)
        {
            spriteBatch.Draw(
                cocoLander.Graphic.TextureAsset.Texture,
                cocoLander.Position,
                cocoLander.Tint
            );
        }
        
        public static void DrawAdvanced(this SpriteBatch spriteBatch, CocoLander cocoLander)
        {
            spriteBatch.Draw(
                cocoLander.Graphic.TextureAsset.Texture,
                cocoLander.Position,
                null,
                cocoLander.Tint,
                0,
                cocoLander.Graphic.CenteredOrigin,
                1,
                SpriteEffects.None, 
                0
            );
        }

        public static void Draw(this SpriteBatch spriteBatch, IDrawable drawable)
        {
            spriteBatch.Draw(
                drawable.Graphic.TextureAsset.Texture,
                drawable.Position,
                drawable.SourceRectangle,
                drawable.Tint,
                drawable.Rotation,
                drawable.Graphic.CenteredOrigin,
                drawable.Scale,
                drawable.SpriteEffects,
                drawable.LayerDepth
            );
        }

        public static void Draw(this SpriteBatch spriteBatch, IDrawable2 drawable)
        {
            spriteBatch.Draw(
                drawable.Graphic.TextureAsset.Texture,
                drawable.Position,
                drawable.SourceRectangle,
                drawable.Tint,
                drawable.Rotation,
                drawable.Graphic.CenteredOrigin,
                drawable.Scale,
                drawable.SpriteEffects,
                drawable.LayerDepth
            );
        }
    }
}

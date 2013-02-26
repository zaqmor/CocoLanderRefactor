using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocoLander.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CocoLander.Interfaces
{
    public interface IDrawable
    {
        Graphic Graphic { get; }
        Vector2 Position { get; }
        Rectangle SourceRectangle { get; }
        Color Tint { get; }
        float Rotation { get; }
        float Scale { get; }
        SpriteEffects SpriteEffects { get; }
        float LayerDepth { get; }
    }

    public interface IDrawable2
    {
        IGraphic Graphic { get; }
        Vector2 Position { get; }
        Rectangle SourceRectangle { get; }
        Color Tint { get; }
        float Rotation { get; }
        float Scale { get; }
        SpriteEffects SpriteEffects { get; }
        float LayerDepth { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocoLander.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace CocoLander.Interfaces
{
    public interface IGraphic
    {
        TextureAsset2 TextureAsset { get; }

        int Width { get; }
        int Height { get; }
        Color DefaultTint { get; }
        
        void LoadContent(ContentManager contentManager);

        Vector2 CenteredOrigin { get; }
    }
}

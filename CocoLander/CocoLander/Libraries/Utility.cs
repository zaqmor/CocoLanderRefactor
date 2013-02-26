using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CocoLander
{
    public static class Utility
    {
        public static Vector2 GetMousePosition()
        {
            var mouse = Mouse.GetState();
            return new Vector2(mouse.X, mouse.Y);
        }
    }
}

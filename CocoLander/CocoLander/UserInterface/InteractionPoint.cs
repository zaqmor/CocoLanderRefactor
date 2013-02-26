using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace CocoLander
{
    public enum InteractionPointState
    {
        None,
        Hover,
        Pressed,
        LongPressed,
        LeftClicked,
        RightClicked,
        DoubleClicked
    }

    public class InteractionPoint
    {
        public Vector2 Position { get; protected set; }
        public InteractionPointState State { get; protected set; }

        public InteractionPoint()
        {
            Position = new Vector2();
            State = InteractionPointState.None;
        }
    }
}

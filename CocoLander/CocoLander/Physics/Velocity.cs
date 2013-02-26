using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace CocoLander
{
    public class Velocity
    {
        public Vector2 Direction { get; set; }
        public float Magnitude { get; set; }
        public Func<bool> IsActive { get; protected set; } 

        public Velocity()
        {
            Direction = new Vector2();
            Magnitude = 1f;
            IsActive = () => true ;
        }

        public Velocity(Func<bool> isActive)
            : this()
        {
            IsActive = isActive;
        }

        public Velocity(Vector2 direction, float magnitude, Func<bool> isActive)
            : this()
        {
            Direction = direction;
            Magnitude = magnitude;
            IsActive = isActive;
        }
    }
}

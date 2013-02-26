using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CocoLander
{
    public class CocoLander
    {
        public CocoLanderGraphic Graphic { get; protected set; }

        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }

        public Func<GameTime, Vector2> Gravity { get; set; }
        public Func<GameTime, Vector2> Thrust { get; set; }

        public readonly Color DefaultTint = Color.White;
        public readonly Color ThrustTint = Color.OrangeRed; 

        public double Fuel { get; set; }

        public CocoLander()
        {
            Graphic = new CocoLanderGraphic();

            Position = new Vector2();
            Velocity = new Vector2();
            Fuel = 500d;

            Gravity = GetDefaultGravity;
            Thrust = GetDefaultThrust;
        }

        public bool ThrustIsActive
        {
            get
            {
                return Mouse.GetState().RightButton == ButtonState.Pressed;
            }
        }

        public Color Tint
        {
            get
            {
                return
                    ThrustIsActive
                        ? ThrustTint
                        : DefaultTint;   
            }
        }

        public Vector2 GetDefaultThrust( GameTime gameTime )
        {
            return
                ThrustIsActive
                    ? new Vector2(0, -2 * GetTimeScaleMultiplier(gameTime)) 
                    : new Vector2();
        }

        public Vector2 GetDefaultGravity(GameTime gameTime)
        {
            return new Vector2(0, 1 * GetTimeScaleMultiplier(gameTime));
        }

        public float GetTimeScaleMultiplier(GameTime gameTime)
        {
            return (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2000;
        }

        public void Update(GameTime gameTime)
        {
            MoveToInteractionPoint(gameTime);
            ApplyForce(Gravity(gameTime));

            //todo: force is hooked up to mouse but color should be too... RX??
            ApplyForce(Thrust(gameTime));
        }

        public void ApplyForce(Vector2 force)
        {
            Velocity = Velocity.Add(force);
            Position = Position.Add(Velocity);
        }

        public void ApplyInteraction(Game game)
        {
            var mouseState = Mouse.GetState();
#if WINDOWS
            var mouseX = mouseState.X;
            var mouseY = mouseState.X;
#endif
        }

        public void MoveToInteractionPoint(GameTime gameTime)
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Position = Utility.GetMousePosition();
                Velocity = new Vector2();
            }
        }


        //public Rectangle ScreenRectangle
        //{
        //    get
        //    {
        //        return
        //            new Rectangle(
        //                (int)( Position.X - (float)Graphic.Width / 2),
        //                (int)( Position.Y - (float)Graphic.Height / 2),
        //                Graphic.Width,
        //                Graphic.Height
        //            );
        //    }
        //}

        public static void LoadContent(ContentManager contentManager)
        {
            CocoLanderGraphic.LoadContent(contentManager);
        }
    }

}

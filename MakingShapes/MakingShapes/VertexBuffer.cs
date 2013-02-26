using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace MakingShapes
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public abstract class VertexPositionColorBuffer : Microsoft.Xna.Framework.DrawableGameComponent 
    {
        private VertexPositionColor[] _buffer;
        private readonly PrimitiveType _primitiveType;
        private readonly int _vertexOffset = 0;
        private readonly Func<VertexPositionColor[]> _loadingFunc;
        private int[] _indexData;
        private int _indexOffset;
        private int _primitivesCount;

        protected VertexPositionColorBuffer(
            Game game, 
            Func<VertexPositionColor[]> loadingFunc, 
            PrimitiveType primitiveType
        )
            : base(game)
        {
            _primitiveType = primitiveType;
            _loadingFunc = loadingFunc;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            _buffer = _loadingFunc();

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>( 
                _primitiveType,
                _buffer,
                _vertexOffset,
                _buffer.Length,
                _indexData,
                _indexOffset,
                _primitivesCount);

            base.Draw(gameTime);
        }
    }
}

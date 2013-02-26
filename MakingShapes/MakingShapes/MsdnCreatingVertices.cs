using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MakingShapes
{
    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/bb196414(v=xnagamestudio.40).aspx
    /// </summary>
    

    public class MsdnCreatingVertices
    {
        public static VertexPositionColor[] CreatePointList(int pointCount)
        {
            var pointList = new VertexPositionColor[pointCount];

            for (int x = 0; x < pointCount / 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    pointList[(x * 2) + y] = new VertexPositionColor(
                        new Vector3(x * 100, y * 100, 0), Color.White);
                }
            }

            return pointList;
        }

        public static void CreateViewMatrix()
        {
            var cameraPosition = new Vector3(0.0f, 0.0f, 1.0f);
            var cameraTarget = Vector3.Zero;
            var cameraUpVector = Vector3.Up;

            var viewMatrix = Matrix.CreateLookAt(
                cameraPosition,
                cameraTarget,
                cameraUpVector);
        }

        public static void CreateProjectionMatrix(Game game)
        {
            var pmLeft = 0;
            var pmRight = (float)game.GraphicsDevice.Viewport.Width;
            var pmBottom = (float)game.GraphicsDevice.Viewport.Height;
            var pmTop = 0;
            var pmZNearPlane = 1.0f;
            var pmZFarPlane = 1000.0f;

            var projectionMatrix = Matrix.CreateOrthographicOffCenter(
                pmLeft,
                pmRight,
                pmBottom,
                pmTop,
                pmZNearPlane,
                pmZFarPlane);
        }

        public static short[] CreateLineList( VertexPositionColor[] pointList )
        {
            var pointCount = pointList.Length;
            var lineList = new short[(pointCount * 2) - 2];

            for (int i = 0; i < pointCount - 1; i++)
            {
                lineList[i * 2] = (short)(i);
                lineList[(i * 2) + 1] = (short)(i + 1);
            }

            return lineList;
        }

        public static void DrawLineList(
            Game game, 
            VertexPositionColor[] pointList, 
            short[] lineList)
        {
            var pointCount = pointList.Length;
            var primitiveType = PrimitiveType.LineList;
            var vertexOffset = 0;
            var firstElementToRead = 0;
            var indexOffset = 0;
            var primitiveCount = 7;

            game.GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(
                primitiveType,
                pointList,
                vertexOffset,
                pointCount,
                lineList,
                indexOffset,
                primitiveCount);
        }
    }
}

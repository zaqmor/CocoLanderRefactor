using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace CocoLander
{
    public static class StructMixins
    {
        //public static TStruct PlusEquals<TStruct>(this TStruct @struct, Func<TStruct, TStruct> func)
        //    where TStruct : struct
        //{

        //}

        public static TStruct Apply<TStruct>(this TStruct @struct, Func<TStruct, TStruct> func)
            where TStruct : struct
        {
            var s = @struct;
            s = func(s);
            return s;
        }

        public static Vector2 Add(this Vector2 v1, Vector2 v2)
        {
            return Vector2.Add(v1, v2);
        }
    }
}

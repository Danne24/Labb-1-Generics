using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1___Generics
{
    public class BoxSameDimensions : EqualityComparer<Box>
    {
        public override bool Equals(Box box1, Box box2)
        {
            if (box1.Height == box2.Height && box1.Length == box2.Length && box1.Width == box2.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box box)
        {
            int hCode = box.Height ^ box.Length ^ box.Width;
            return hCode.GetHashCode();
        }
    }
}

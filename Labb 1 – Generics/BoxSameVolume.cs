using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1___Generics
{
    public class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box box1, Box box2)
        {
            if ((box1.Height * box1.Length * box1.Width) == (box2.Height * box2.Length * box2.Width))
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
            Console.WriteLine("HashCode: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}

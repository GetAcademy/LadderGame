using System;
using System.Collections.Generic;
using System.Text;

namespace LadderGame
{
    public class Ladder
    {
        public int FromIndex { get; }
        public int ToIndex { get; }

        public Ladder(int fromIndex, int toIndex)
        {
            ToIndex = toIndex;
            FromIndex = fromIndex;
        }
    }
}

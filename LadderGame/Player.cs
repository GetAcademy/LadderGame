using System;
using System.Collections.Generic;
using System.Text;

namespace LadderGame
{
    public class Player
    {
        private Board _board;

        public Player(Board board)
        {
            _board = board;
        }

        public int CurrentSquareIndex { get; private set; }

        public void Move(int stepCount)
        {
            var index = CurrentSquareIndex + stepCount;
            if (index > 90) index = 90 - (index - 90);
            index = _board.GetLadderDestination(index);
            CurrentSquareIndex = index;
        }
    }
}

using System.Linq;
using Microsoft.VisualBasic;

namespace LadderGame
{
    public class Board
    {
        private readonly Player[] _players;
        private readonly Ladder[] _ladders;

        public Board(int playerCount)
        {
            _players = new Player[playerCount];
            for (var i = 0; i < _players.Length; i++)
            {
                _players[i] = new Player(this);
            }
            _ladders = new[]
            {
                new Ladder(1,40), 
                new Ladder(3,33), 
                new Ladder(5,24), 
                new Ladder(8,10), 
                new Ladder(12,74), 
                new Ladder(24,5), 
                new Ladder(27,64), 
                new Ladder(33,3), 
                new Ladder(87,70), 
            };
        }

        public Player GetPlayer(int playerIndex)
        {
            if (playerIndex < 0 || playerIndex >= _players.Length) return null;
            return _players[playerIndex];
        }

        public int GetLadderDestination(int fromIndex)
        {
            var ladder = _ladders.SingleOrDefault(l => l.FromIndex == fromIndex);
            return ladder?.ToIndex ?? fromIndex;
        }
    }
}

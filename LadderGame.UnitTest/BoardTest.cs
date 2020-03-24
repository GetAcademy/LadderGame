using NUnit.Framework;

namespace LadderGame.UnitTest
{
    public class Tests
    {
        [Test]
        public void TestGetPlayer()
        {
            var board = new Board(1);
            var player = board.GetPlayer(0);
            Assert.IsNotNull(player);
        }

        [Test]
        public void TestGetInvalidPlayer()
        {
            var board = new Board(1);
            var player = board.GetPlayer(7);
            Assert.IsNull(player);
        }

        [Test]
        public void TestMoveWithoutLadder()
        {
            var board = new Board(1);
            var player = board.GetPlayer(0);
            player.Move(5);
            Assert.AreEqual(5, player.CurrentSquareIndex);
        }

        [Test]
        public void TestLadder()
        {
            var ladder = new Ladder(1, 40);
            Assert.AreEqual(1, ladder.FromIndex);
            Assert.AreEqual(40, ladder.ToIndex);
        }

        [Test]
        public void TestMoveLadderInBoard()
        {
            var board = new Board(1);
            var destination = board.GetLadderDestination(24);
            Assert.AreEqual(5, destination);
        }

        [Test]
        public void TestMoveLadder()
        {
            var board = new Board(1);
            var player = board.GetPlayer(0);
            player.Move(1);
            Assert.AreEqual(40, player.CurrentSquareIndex);
        }

        [Test]
        public void TestNoGoBeyond90()
        {
            var board = new Board(1);
            var player = board.GetPlayer(0);
            player.Move(89);
            player.Move(4);
            Assert.AreEqual(70, player.CurrentSquareIndex);
        }
    }
}
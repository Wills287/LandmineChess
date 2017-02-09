using NUnit.Framework;

namespace LandmineChess.Tests
{
    [TestFixture]
    public class BoardTests
    {
        Board board;

        [OneTimeSetUp]
        public void SetUp()
        {
            board = new Board(8);
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(0, 7)]
        [TestCase(7, 0)]
        [TestCase(7, 7)]
        public void InitialiseBoardWithEmptySpaces(int x, int y)
        {
            var expected = Icon.Empty;
            var actual = board.GetCharacterAtPosition(new Position(x, y));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InitialiseBoardWithBottomLeftPlayer()
        {
            var expected = Icon.Player;
            var actual = board.GetCharacterAtPosition(new Position(0, 0));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPlayerPositionReturnsPlayer()
        {
            var expected = new Position(0, 0);
            var actual = board.GetPlayerPosition();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

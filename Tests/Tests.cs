using System.Collections.Generic;
using Bowling.Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace Bowling.Tests
{
    [TestFixture]
    public class Tests
    {
        private IGameConfiguration _gameConfiguration;

        [SetUp]
        public void Setup()
        {
            _gameConfiguration = new GameConfiguration();
        }

        [Test, TestCaseSource(typeof(TestFrames), "FramesToUseForTesting")]
        public void RunTestFrames(List<Frame> gameFrames, int expectedFrameScore)
        {
            var game = new Game(_gameConfiguration, gameFrames);

            var expectedValue = expectedFrameScore;
            var actualValue = game.Score();

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

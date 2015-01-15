using System.Collections.Generic;
using Bowling.Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace Bowling.Tests
{
    [TestFixture]
    public class FrameInfoHelperTests
    {
        private IGameConfiguration _gameConfiguration;
        private IFrameInfoHelper _frameInfoHelper;

        [SetUp]
        public void Setup()
        {
            _gameConfiguration = MockRepository.GenerateMock<IGameConfiguration>();
            _gameConfiguration.Stub(x => x.GetAppSetting<int>(Arg.Is("TotalNumberOfPinsToKnockDown"))).Return(10);
            _gameConfiguration.Stub(x => x.GetAppSetting<int>(Arg.Is("NoOfBowlsForAStrike"))).Return(1);
            _gameConfiguration.Stub(x => x.GetAppSetting<int>(Arg.Is("NoOfBowlsForASpare"))).Return(2);
            _frameInfoHelper = new FrameInfoHelper(_gameConfiguration);
        }

        [Test]
        public void Given_A_Stike_Is_Bowled_A_Strike_Is_Reported()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(10)
                            };

            Assert.That(_frameInfoHelper.DoBowlsEqualAStrike(bowls), Is.EqualTo(true));
        }

        [Test]
        public void Given_A_Stike_Is_Not_Bowled_A_Strike_Is_Not_Reported()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(2),
                                new BowlInfo(5)
                            };

            Assert.That(_frameInfoHelper.DoBowlsEqualAStrike(bowls), Is.EqualTo(false));
        }

        [Test]
        public void Given_A_Spare_Is_Bowled_A_Spare_Is_Reported()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(7),
                                new BowlInfo(3)
                            };

            Assert.That(_frameInfoHelper.DoBowlsEqualASpare(bowls), Is.EqualTo(true));
        }

        [Test]
        public void Given_A_Spare_Is_Not_Bowled_A_Spare_Is_Not_Reported()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(2),
                                new BowlInfo(5)
                            };

            Assert.That(_frameInfoHelper.DoBowlsEqualASpare(bowls), Is.EqualTo(false));
        }

        [Test]
        public void Given_A_Strike_Score_Is_Calculated_Correctly()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(10)
                            };

            Assert.That(_frameInfoHelper.GetScoreForAStrike(bowls), Is.EqualTo(10));
        }

        [Test]
        public void Given_A_Spare_Score_Is_Calculated_Correctly()
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(7),
                                new BowlInfo(3)
                            };

            Assert.That(_frameInfoHelper.GetScoreForASpare(bowls), Is.EqualTo(10));
        }

        [TestCase(4, 3, 7)]
        [TestCase(1, 1, 2)]
        public void Given_A_Number_Of_Bowls_When_Added_Up_They_Add_Up_Correctly(int bowl1, int bowl2, int expectedValue)
        {
            var bowls = new List<IBowlInfo>()
                            {
                                new BowlInfo(bowl1),
                                new BowlInfo(bowl2)
                            };

            Assert.That(_frameInfoHelper.GetTotalScoreOfAllBowlsForFrame(bowls), Is.EqualTo(expectedValue));
        }

    }
}

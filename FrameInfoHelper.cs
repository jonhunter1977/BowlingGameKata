using System;
using System.Collections.Generic;
using System.Linq;
using Bowling.Interfaces;

namespace Bowling
{
    public class FrameInfoHelper : IFrameInfoHelper
    {
        private readonly IGameConfiguration _gameConfiguration;
        private readonly int _totalNumberOfPinsToKnockDown;
        private readonly int _noOfBowlsForAStrike;
        private readonly int _noOfBowlsForASpare;

        public FrameInfoHelper(IGameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;

            _totalNumberOfPinsToKnockDown = _gameConfiguration.GetAppSetting<int>("TotalNumberOfPinsToKnockDown");
            _noOfBowlsForAStrike = _gameConfiguration.GetAppSetting<int>("NoOfBowlsForAStrike");
            _noOfBowlsForASpare = _gameConfiguration.GetAppSetting<int>("NoOfBowlsForASpare");
        }

        public bool DoBowlsEqualAStrike(List<IBowlInfo> bowls)
        {
            if (bowls.Count < _noOfBowlsForAStrike) return false;

            var testForAStrikeScore = 0;

            for (var a = 0; a < _noOfBowlsForAStrike; a++)
            {
                testForAStrikeScore += bowls[a].GetNoOfBowlsKnockedDown();
            }

            return testForAStrikeScore == _totalNumberOfPinsToKnockDown;
        }

        public bool DoBowlsEqualASpare(List<IBowlInfo> bowls)
        {
            if (bowls.Count < _noOfBowlsForASpare) return false;

            var testForASpareScore = 0;

            for (var a = 0; a < _noOfBowlsForASpare; a++)
            {
                testForASpareScore += bowls[a].GetNoOfBowlsKnockedDown();
            }

            return testForASpareScore == _totalNumberOfPinsToKnockDown;
        }

        public int GetScoreForAStrike(List<IBowlInfo> bowls)
        {
            var scoreForAStrike = 0;

            for (var a = 0; a < _noOfBowlsForAStrike; a++)
            {
                scoreForAStrike += bowls[a].GetNoOfBowlsKnockedDown();
            }

            return scoreForAStrike;
        }

        public int GetScoreForASpare(List<IBowlInfo> bowls)
        {
            var scoreForASpare = 0;

            for (var a = 0; a < _noOfBowlsForASpare; a++)
            {
                scoreForASpare += bowls[a].GetNoOfBowlsKnockedDown();
            }

            return scoreForASpare;
        }

        public int GetTotalScoreOfAllBowlsForFrame(List<IBowlInfo> bowls)
        {
            return bowls.Sum(t => t.GetNoOfBowlsKnockedDown());
        }

        public int GetTotalScoreForRequestedNumberOfBowlsForFrame(List<IBowlInfo> bowls, int noOfBowls)
        {
            var scoreForRequestedNoOfBowls = 0;

            for (var a = 0; a < noOfBowls; a++)
            {
                scoreForRequestedNoOfBowls += bowls[a].GetNoOfBowlsKnockedDown();
            }

            return scoreForRequestedNoOfBowls;
        }

        public int GetRequestedBowlScore(List<IBowlInfo> bowls, int bowlNumber)
        {
            return bowls[bowlNumber - 1].GetNoOfBowlsKnockedDown();
        }
    }
}

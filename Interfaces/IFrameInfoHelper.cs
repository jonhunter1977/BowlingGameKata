using System.Collections.Generic;

namespace Bowling.Interfaces
{
    public interface IFrameInfoHelper
    {
        bool DoBowlsEqualAStrike(List<IBowlInfo> bowls);
        bool DoBowlsEqualASpare(List<IBowlInfo> bowls);
        int GetScoreForAStrike(List<IBowlInfo> bowls);
        int GetScoreForASpare(List<IBowlInfo> bowls);
        int GetTotalScoreOfAllBowlsForFrame(List<IBowlInfo> bowls);
        int GetTotalScoreForRequestedNumberOfBowlsForFrame(List<IBowlInfo> bowls, int noOfBowls);
        int GetRequestedBowlScore(List<IBowlInfo> bowls, int bowlNumber);
    }
}

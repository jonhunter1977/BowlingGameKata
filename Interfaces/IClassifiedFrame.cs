using System.Collections.Generic;

namespace Bowling.Interfaces
{
    public interface IClassifiedFrame
    {
        //void SetFrameNumber(int frameNumber);
        //int GetBowl1NoOfPinsKnockedDown();
        //int GetBowl2NoOfPinsKnockedDown();
        //int GetBowl3NoOfPinsKnockedDown();
        int GetScoreForRequestedNumberOfBowls(int noOfBowls);
        void IncrementPreviousStrikeCount();
        int Score();
        int Score(List<IClassifiedFrame> remainingFrames);
    }
}
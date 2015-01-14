using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    public abstract class ClassifiedFrame : IClassifiedFrame
    {
        private readonly IFrameInfoHelper _frameInfoHelper;
        private readonly IFrameInfo _frameInfo;

        protected ClassifiedFrame(IFrameInfoHelper frameInfoHelper, IFrameInfo frameInfo)
        {
            _frameInfo = frameInfo;
            _frameInfoHelper = frameInfoHelper;
        }

        public virtual int GetScoreForRequestedNumberOfBowls(int noOfBowls)
        {
            return _frameInfoHelper.GetTotalScoreForRequestedNumberOfBowlsForFrame(_frameInfo.GetBowlsInFrame(), noOfBowls);
        }

        public virtual void IncrementPreviousStrikeCount()
        {
            throw new System.NotImplementedException();
        }

        public virtual int Score()
        {
            return _frameInfoHelper.GetTotalScoreOfAllBowlsForFrame(_frameInfo.GetBowlsInFrame());
        }

        public virtual int Score(List<IClassifiedFrame> remainingFrames)
        {
            return Score();
        }
    }
}

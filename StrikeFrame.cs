using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    class StrikeFrame : ClassifiedFrame
    {
        private readonly IFrameInfoHelper _frameInfoHelper;
        private readonly IFrameInfo _frameInfo;
        private int _previousStrikes;

        public StrikeFrame(IFrameInfoHelper frameInfoHelper, IFrameInfo frameInfo)
            : base(frameInfoHelper, frameInfo)
        {
            _frameInfo = frameInfo;
            _frameInfoHelper = frameInfoHelper;
        }

        public override void IncrementPreviousStrikeCount()
        {
            _previousStrikes++;
        }

        public override int Score(List<IClassifiedFrame> remainingFrames)
        {
            if (_previousStrikes == 2)
            {
                return GetScoreForRequestedNumberOfBowls(1);
            }

            var frameScore = 0;
                
            var nextFrame = remainingFrames[0];

            if (nextFrame.GetType() == typeof(LastFrame))
            {
                frameScore = 10 + nextFrame.GetScoreForRequestedNumberOfBowls(2);
                return frameScore;
            }

            var nextFramePlus1 = remainingFrames[1];

            if (nextFrame.GetType() == typeof(StrikeFrame))
            {
                nextFrame.IncrementPreviousStrikeCount();
                frameScore = 10 + nextFrame.GetScoreForRequestedNumberOfBowls(1) + nextFramePlus1.GetScoreForRequestedNumberOfBowls(1);
                return frameScore;
            }
                
            frameScore = 10 + nextFrame.Score();
            return frameScore;
        }
    }
}

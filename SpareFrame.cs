using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    class SpareFrame : ClassifiedFrame
    {
        private readonly IFrameInfoHelper _frameInfoHelper;
        private readonly IFrameInfo _frameInfo;

        public SpareFrame(IFrameInfoHelper frameInfoHelper, IFrameInfo frameInfo)
            : base(frameInfoHelper, frameInfo)
        {
            _frameInfo = frameInfo;
            _frameInfoHelper = frameInfoHelper;
        }

        public override int Score(List<IClassifiedFrame> remainingFrames)
        {
            var nextFrame = remainingFrames[0];
            return 10 + nextFrame.GetScoreForRequestedNumberOfBowls(1);
        }
    }
}

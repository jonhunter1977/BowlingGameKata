using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    class LastFrame : ClassifiedFrame
    {
        private readonly IFrameInfoHelper _frameInfoHelper;
        private readonly IFrameInfo _frameInfo;

        public LastFrame(IFrameInfoHelper frameInfoHelper, IFrameInfo frameInfo)
            : base(frameInfoHelper, frameInfo)
        {
            _frameInfo = frameInfo;
            _frameInfoHelper = frameInfoHelper;
        }

        public override int Score()
        {
            if(_frameInfoHelper.DoBowlsEqualAStrike(_frameInfo.GetBowlsInFrame()))
            {
                return 10 + _frameInfoHelper.GetRequestedBowlScore(_frameInfo.GetBowlsInFrame(), 2) + _frameInfoHelper.GetRequestedBowlScore(_frameInfo.GetBowlsInFrame(), 3);
            }

            if (_frameInfoHelper.DoBowlsEqualASpare(_frameInfo.GetBowlsInFrame()))
            {
                return 10 + _frameInfoHelper.GetRequestedBowlScore(_frameInfo.GetBowlsInFrame(), 3);
            }

            return _frameInfoHelper.GetTotalScoreForRequestedNumberOfBowlsForFrame(_frameInfo.GetBowlsInFrame(), 2);
        }
    }
}

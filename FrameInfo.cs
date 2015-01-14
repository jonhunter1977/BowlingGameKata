using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    class FrameInfo : IFrameInfo
    {
        private readonly List<IBowlInfo> _bowls;
        private int _frameNumber;
        private readonly bool _isLastFrame;

        public FrameInfo()
        {
            _bowls = new List<IBowlInfo>();
        }

        public FrameInfo(IEnumerable<IBowlInfo> bowls)
            : this()
        {
            foreach (var bowl in bowls)
            {
                LogBowl(bowl);
            }
        }

        public FrameInfo(IEnumerable<IBowlInfo> bowls, bool isLastFrame)
            : this()
        {
            foreach (var bowl in bowls)
            {
                LogBowl(bowl);
            }

            _isLastFrame = isLastFrame;
        }

        public void LogBowl(IBowlInfo bowlInfo)
        {
            _bowls.Add(bowlInfo);
        }

        public void SetFrameNumber(List<IClassifiedFrame> classifiedFrames)
        {
            _frameNumber = classifiedFrames.Count;
        }

        public int GetFrameNumber()
        {
            return _frameNumber;
        }

        public List<IBowlInfo> GetBowlsInFrame()
        {
            return _bowls;
        }

        public IClassifiedFrame ClassifyFrame(IFrameInfoHelper frameInfoHelper)
        {
            if (_isLastFrame)
            {
                return new LastFrame(frameInfoHelper, this);
            }

            if(frameInfoHelper.DoBowlsEqualAStrike(_bowls))
            {
                return new StrikeFrame(frameInfoHelper, this);
            }

            if (frameInfoHelper.DoBowlsEqualASpare(_bowls))
            {
                return new SpareFrame(frameInfoHelper, this);
            }

            return new StandardFrame(frameInfoHelper, this);
        }
    }
}

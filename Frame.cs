using System;
using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    public class Frame : IFrame
    {
        private readonly IFrameInfo _frameInformation;

        public Frame(IFrameInfo frameInformation)
        {
            _frameInformation = frameInformation;
        }

        public void Bowl(IBowlInfo bowl)
        {
            _frameInformation.LogBowl(bowl);
        }

        public void Classify(IGameConfiguration gameConfiguration, List<IClassifiedFrame> classifiedFrames)
        {
            _frameInformation.SetFrameNumber(classifiedFrames);
            classifiedFrames.Add(_frameInformation.ClassifyFrame(new FrameInfoHelper(gameConfiguration)));
        }
    }
}
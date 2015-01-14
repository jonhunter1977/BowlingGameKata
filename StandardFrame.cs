using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    class StandardFrame : ClassifiedFrame
    {
        public StandardFrame(IFrameInfoHelper frameInfoHelper, IFrameInfo frameInfo)
            : base(frameInfoHelper, frameInfo)
        {
            //Uses base functionality
        }
    }
}

using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling.Interfaces
{
    public interface IFrame
    {
        void Bowl(IBowlInfo bowl);
        void Classify(IGameConfiguration gameConfiguration, List<IClassifiedFrame> classifiedFrames);
    }
}

using System.Collections.Generic;

namespace Bowling.Interfaces
{
    public interface IFrameInfo
    {
        void LogBowl(IBowlInfo bowlInfo);
        void SetFrameNumber(List<IClassifiedFrame> classifiedFrames);
        int GetFrameNumber();
        List<IBowlInfo> GetBowlsInFrame();
        IClassifiedFrame ClassifyFrame(IFrameInfoHelper frameInfoHelper);
    }
}

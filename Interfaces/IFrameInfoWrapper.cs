using System.Collections.Generic;

namespace Bowling.Interfaces
{
    public interface IFrameInfoWrapper
    {
        IFrameInfo CreateFrameInfo(IEnumerable<IBowlInfo> bowls);
        IFrameInfo CreateFrameInfo(IEnumerable<IBowlInfo> bowls, bool isLastFrame);
    }
}

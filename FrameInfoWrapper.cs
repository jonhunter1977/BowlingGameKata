using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    public class FrameInfoWrapper : IFrameInfoWrapper
    {
        private readonly IGameConfiguration _gameConfiguration;

        public FrameInfoWrapper(IGameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;
        }

        public IFrameInfo CreateFrameInfo(IEnumerable<IBowlInfo> bowls)
        {
            return new FrameInfo(bowls);
        }

        public IFrameInfo CreateFrameInfo(IEnumerable<IBowlInfo> bowls, bool isLastFrame)
        {
            return new FrameInfo(bowls, isLastFrame);
        }
    }
}

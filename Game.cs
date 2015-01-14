using System.Collections.Generic;
using Bowling.Interfaces;

namespace Bowling
{
    public class Game
    {
        private readonly IGameConfiguration _gameConfiguration;
        private readonly List<IClassifiedFrame> _classifiedFrames;

        public Game(IGameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;
            _classifiedFrames = new List<IClassifiedFrame>();
        }

        public Game(IGameConfiguration gameConfiguration, IEnumerable<IFrame> gameFrames)
            : this(gameConfiguration)
        {
            foreach (var frame in gameFrames)
            {
                frame.Classify(_gameConfiguration, _classifiedFrames);
            }
        }

        public int Score()
        {
            var score = 0;

            for(var a = 0 ; a < _classifiedFrames.Count; a++)
            {
                var currentFrame = _classifiedFrames[a];
                var numberOfRemainingFramesAfterThisFrame = _classifiedFrames.Count - (a + 1);

                score += currentFrame.Score(new List<IClassifiedFrame>(_classifiedFrames.GetRange(a + 1, numberOfRemainingFramesAfterThisFrame)));
            }

            return score;
        }
    }
}
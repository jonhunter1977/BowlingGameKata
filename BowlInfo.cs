using Bowling.Interfaces;

namespace Bowling
{
    public class BowlInfo : IBowlInfo
    {
        private readonly int _noOfPinsKnockedDown;

        public BowlInfo(int noOfPinsKnockedDown)
        {
            _noOfPinsKnockedDown = noOfPinsKnockedDown;
        }

        public int GetNoOfBowlsKnockedDown()
        {
            return _noOfPinsKnockedDown;
        }
    }
}

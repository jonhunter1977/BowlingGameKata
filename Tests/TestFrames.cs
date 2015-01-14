using System.Collections.Generic;
using Bowling.Interfaces;
using NUnit.Framework;

namespace Bowling.Tests
{
    public class TestFrames
    {
        static IGameConfiguration gameConfiguration = new GameConfiguration();
        static IFrameInfoWrapper frameInfoWrapper = new FrameInfoWrapper(gameConfiguration);

        public static object[] FramesToUseForTesting =
        {
            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)}, true))  //2
                },
                20
            )
            .SetName("All frames do not contain spares or strikes"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //11
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //11
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //11
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //11
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //11
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)}, true))  //2
                },
                65
            )
            .SetName("Every other frame is a spare, last frame does not contain spares or strikes"),           

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //17
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(7), new BowlInfo(3)})), //14
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(4), new BowlInfo(3)})), //7
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(5)})), //6
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(2), new BowlInfo(1)})), //3
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(1), new BowlInfo(1)})), //2
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(6), new BowlInfo(2)})), //8
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(2), new BowlInfo(4)})), //6
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(2), new BowlInfo(2)}, true))  //4
                },
                76
            )
            .SetName("First 2 frames are spares, the rest do not contain spares or strikes"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10),new BowlInfo(0)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9 
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)}, true))  //9
                },
                100
            )
            .SetName("First frame is a strike the rest do not contain strikes or spares"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //28
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9 
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)}, true))  //9
                },
                119
            )
            .SetName("First 2 frames are strikes the rest do not contain strikes or spares"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(5), new BowlInfo(4)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(3), new BowlInfo(6)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9 
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1), new BowlInfo(5)}, true))  //15
                },
                96
            )
            .SetName("Last frame contains a spare"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(5), new BowlInfo(4)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(3), new BowlInfo(6)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9 
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(8), new BowlInfo(1)})), //9
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0), new BowlInfo(9)}, true))  //19
                },
                100
            )
            .SetName("Last frame contains a strike"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30 (270)
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(10), new BowlInfo(10)}, true))  //30
                },
                300
            )
            .SetName("Perfect game of all strikes"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1)})), //19
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(9), new BowlInfo(1), new BowlInfo(9)}, true))  //19
                },
                190
            )
            .SetName("Game of half strikes"),

            new TestCaseData
            (
                new List<Frame>
                {
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //30
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //20
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(10), new BowlInfo(0)})), //10
                    new Frame(frameInfoWrapper.CreateFrameInfo(new List<IBowlInfo>(){new BowlInfo(0), new BowlInfo(0)}, true))  //0
                },
                240
            )
            .SetName("All frames are strikes apart from the last frame where 0 is scored")
        };
    }
}

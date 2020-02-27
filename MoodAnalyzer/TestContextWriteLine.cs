using System;

namespace MoodAnalyzer
{
    internal class TestContextWriteLine
    {
        private Action writeLine;

        public TestContextWriteLine(Action writeLine)
        {
            this.writeLine = writeLine;
        }
    }
}
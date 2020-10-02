using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProgram
{
    class AddNumbers
    {
        private readonly NLog nLog = new NLog();
        public int Sum(int SecondNum, int FirstNum)
        {
            if (FirstNum == 0 || SecondNum == 0)
            {
                nLog.LogDebug("Debug Unsuccessful : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("First Number & Second Number shouldnot be equal to 0");
            }
            int result = FirstNum + SecondNum;
            nLog.LogDebug("Debug Successful : Sum()");
            nLog.LogInfo("Sum method passed, Result" + result);
            return result;
        }
    }
}

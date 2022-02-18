using System;

namespace FrequencyCounter_NetCore31
{
    class Program
    {
        static void Main(string[] args)
        {
            FreqCalc.FrequencyCounterInStringArray(new[] { "a", "ab", "abc" }, new[] { "ab", "abc", "abcd" });
        }
    }
}

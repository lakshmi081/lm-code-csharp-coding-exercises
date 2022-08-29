using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            bool isResult = false;
            if (string.IsNullOrEmpty(input))
                return isResult;
            string alphabetsAll = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            foreach (char alpha in alphabetsAll)
            {
                foreach (char ip in input.ToLower())
                {
                    if (alpha == ip)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
                isResult = true;
            return isResult;
        }
    }
}
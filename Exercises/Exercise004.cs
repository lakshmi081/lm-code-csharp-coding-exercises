using System;
namespace Exercises
{
    public class Exercise004
    {
        const double GIGASECOND = 1E9;

        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            dateTime = dateTime.AddSeconds(GIGASECOND);
            return dateTime;
        }
    }
}
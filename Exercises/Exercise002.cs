using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            bool isResult = false;
            if (person == null)
                return isResult;
            string city = person.City;
            if (string.IsNullOrEmpty(city))
                return isResult;
            if (city.Equals("Manchester"))
                isResult = true;
            return isResult;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            bool isResult = false;
            if (person.Age >= ageLimit)
                isResult = true;
            return isResult;
        }
    }
}

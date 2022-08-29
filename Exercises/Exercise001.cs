using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;
            if (word.Length == 1)
                return word.ToUpper();
            return word.Remove(1).ToUpper() + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            String initials = "";
            if (firstName.Length >= 1 && lastName.Length >= 1)
                initials = firstName.Remove(1).ToUpper() + "." + lastName.Remove(1).ToUpper();
            return initials;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            double rate = (vatRate + 100) / 100;
            double val = originalPrice * rate;
            val = Math.Round(val, 2);
            return val;
        }

        public string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return sentence;
            char[] chars = new char[sentence.Length];
            for (int start = 0, end = sentence.Length - 1; start <= end; start++, end--)
            {
                chars[start] = sentence[end];
                chars[end] = sentence[start];
            }
            return new string(chars);
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            if (users == null || users.Count == 0)
            {
                return count;
            }
            foreach (User linux in users)
            {
                if ("LINUX".Equals(linux.Type.ToUpper()))
                    count++;
            }
            return count;

        }

    }
}

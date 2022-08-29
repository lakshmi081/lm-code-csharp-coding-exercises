using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour)
        {
            int code = -1;
            foreach (string flavour in IceCreamFlavours)
            {
                code++;
                if (flavour.Equals(iceCreamFlavour))
                {
                    break;
                }
            }
            return code;
        }
    }
}
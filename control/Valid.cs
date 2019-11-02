using System;

namespace ProgramRecipe
{
    static class Valid
    {
        public static bool ValidAge(string txt)
        {
            Byte age;
            checked
            {
                try
                {
                    age = Convert.ToByte(txt);
                    if (!(age >= 1 && age <= 110))
                        return true;
                }
                catch (OverflowException)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

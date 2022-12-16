using System;

namespace KnoxLogic
{
	public class Toolbox
	{
        public static int generateRandomValues(int a, int b)
        {
            Random rnd = new Random();
            int num = rnd.Next(a, b);
            return num;
        }

		public static string generateId(string constanty)
		{
            decimal randomNumber = Math.Round(Convert.ToDecimal(generateRandomValues(2, 89)) * 69 + 39);

            string reference = constanty + "_" + randomNumber;

            if (reference.Length > 5)
            {
                reference = reference.Substring(0, 5);
            }

            return reference;
        }
	}
}


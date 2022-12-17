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

		public static int generateId()
		{
            int randomNumber = (int)Math.Round(Convert.ToDecimal(generateRandomValues(2, 89)) * 69 + 39);

            return randomNumber;
        }
	}
}


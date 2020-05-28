namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			if (count==1) return "рубль";
			var tens = count % 10;//десятки
			if (count > 20)
			{
				tens = count/10%10;
				count %= 10;
			}
			if (count == 1 && tens != 1) return "рубль";
			if (tens != 1 && ((count == 2) || (count == 3) || (count == 4)) ) return "рубля";
			else  return "рублей";
			//else if (count == 1) return "рубль";
		}
	}
}
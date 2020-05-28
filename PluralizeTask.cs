namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			if (count==1) return "рубль";
			if (count > 19)	count %= 10;
			if ((count == 2) || (count == 3) || (count == 4)) return "рубля";
			else  return "рублей";
		}
	}
}
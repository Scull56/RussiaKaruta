﻿namespace RussianKaruta.Data
{
	public static class CardsInitializer
	{
		private static string[] values { get; set; } = new string[] { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" };

		private static string[] valuesName { get; set; } = new string[] { "туз", "двойка", "тройка", "четверка", "пятёрка", "шестёрка", "семёрка", "восьмёрка", "девятка", "десятка", "валет", "королева", "король" };

		private static string[] types { get; set; } = new string[] { "diamond", "spade", "cross", "heart" };

		private static string[] typesName { get; set; } = new string[] { "бубен", "пики", "крести", "черви" };

		private static List<Card> Cards = new List<Card>();

		static CardsInitializer()
		{
			for (var i = 0; i < values.Length; i++)
			{
				for (var j = 0; j < types.Length; j++)
				{
					Cards.Add(new Card() { ImgSrc = $"images/{values[i]}_{types[j]}.png", Name = $"{valuesName[i]} {typesName[j]}" });
				}
			}
		}

		public static IEnumerable<Card> GetCards()
		{
			return new List<Card>(Cards);
		}
	}
}
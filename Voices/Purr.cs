using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Мурлыкать
	/// Наследует интерфейс IVoice
	/// </summary>
	public class Purr : IVoice
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Purr"
		/// </summary>
		public Purr()
		{
			type = "Purr";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Speak"/>
		/// </summary>
		/// <returns>Строка "Я мурлыкаю"</returns>
		public string Speak()
		{
			return "I'm purring";
		}
	}
}

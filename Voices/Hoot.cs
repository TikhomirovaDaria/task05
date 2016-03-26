using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Ухать
	/// Наследует интерфейс IVoice
	/// </summary>
	public class Hoot : IVoice
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Hoot"
		/// </summary>
		public Hoot()
		{
			type = "Hoot";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Speak"/>
		/// </summary>
		/// <returns>Строка "Я ухаю"</returns>
		public string Speak()
		{
			return "I'm hooting";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Шипеть
	/// Наследует интерфейс IVoice
	/// </summary>
	public class Hiss : IVoice
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Hiss"
		/// </summary>
		public Hiss()
		{
			type = "Hiss";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Speak"/>
		/// </summary>
		/// <returns>Строка "Я шиплю"</returns>
		public string Speak()
		{
			return "I'm hissing";
		}
	}
}

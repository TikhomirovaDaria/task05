using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Рычать
	/// Наследует интерфейс IVoice
	/// </summary>
	public class Roar : IVoice
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Roar"
		/// </summary>
		public Roar()
		{
			type = "Roar";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Speak"/>
		/// </summary>
		/// <returns>Строка "Я рычу"</returns>
		public string Speak()
		{
			return "I'm roaring";
		}
	}
}

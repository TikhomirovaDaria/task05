using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Охотиться
	/// Наследует интерфейс IMotion
	/// </summary>
	public class Hunt : IMotion
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Hunt"
		/// </summary>
		public Hunt()
		{
			type = "Hunt";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Move"/>
		/// </summary>
		/// <returns>Строка "Я бегу"</returns>
		public string Move()
		{
			return "I'm hunting";
		}
	}
}

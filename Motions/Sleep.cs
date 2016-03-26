using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Спать
	/// Наследует интерфейс IMotion
	/// </summary>
	public class Sleep : IMotion
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Sleep"
		/// </summary>
		public Sleep()
		{
			type = "Sleep";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Move"/>
		/// </summary>
		/// <returns>Строка "Я сплю"</returns>
		public string Move()
		{
			return "I'm sleaping";
		}
	}
}

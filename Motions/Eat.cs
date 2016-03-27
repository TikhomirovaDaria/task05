using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Кушать
	/// Наследует интерфейс IMotion
	/// </summary>
	public class Eat : IMotion
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Eat"
		/// </summary>
		public Eat()
		{
			type = "Eat";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Move"/>
		/// </summary>
		/// <returns>Строка "Я кушаю"</returns>
		public string Move()
		{
			return "I'm eating";
		}
	}
}

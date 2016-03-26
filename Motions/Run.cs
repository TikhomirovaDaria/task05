using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Бежать
	/// Наследует интерфейс IMotion
	/// </summary>
	public class Run : IMotion
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Run"
		/// </summary>
		public Run()
		{
			type = "Run";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Move"/>
		/// </summary>
		/// <returns>Строка "Я бегу"</returns>
		public string Move()
		{
			return "I'm running";
		}
	}
}

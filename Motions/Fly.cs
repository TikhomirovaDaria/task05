using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Летать
	/// Наследует интерфейс IMotion
	/// </summary>
	public class Fly : IMotion
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Fly"
		/// </summary>
		public Fly()
		{
			type = "Fly";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Move"/>
		/// </summary>
		/// <returns>Строка "Я лечу"</returns>
		public string Move()
		{
			return "I'm flying";
		}
	}
}

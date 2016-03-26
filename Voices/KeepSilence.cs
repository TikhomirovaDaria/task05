using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Молчать
	/// Наследует интерфейс IVoice
	/// </summary>
	public class KeepSilence : IVoice
	{
		/// <summary>
		/// Свойство сформированное AutoProperty
		/// Содержит имя класса
		/// </summary>
		public string type { get; private set; }
		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет значение поля <see = cref "type"/>
		/// равным "KeepSilence"
		/// </summary>
		public KeepSilence()
		{
			type = "KeepSilence";
		}
		/// <summary>
		/// Реализация унаследованной функции <see = cref "Speak"/>
		/// </summary>
		/// <returns>Строка "Я молчу"</returns>
		public string Speak()
		{
			return "I'm keeping silence";
		}
	}
}

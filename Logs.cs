using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс осуществляющий создание и работ с логами
	/// </summary>
	public class Logs
	{
		/// <summary>
		/// Объект, через который осуществляется работа с логами
		/// </summary>
		private readonly Logger logger;

		/// <summary>
		/// Конструктор по умлчанию
		/// Создание объекта типа <see = cref "Logger"/>
		/// </summary>
		public Logs()
		{
			logger = LogManager.GetCurrentClassLogger();
		}
		/// <summary>
		/// Формирование и запись лога <see = cref "message"/> с пометкой INFO в файл
		/// </summary>
		/// <param name="message">Сообщение для записи в лог</param>
		public void MakeLog(string message)
		{
			logger.Info(message);
		}
	}
}

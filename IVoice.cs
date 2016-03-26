using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Интерфейс, определяющий единственную функцию Speak()
	/// Наследует интерфейс IType
	/// </summary>
	public interface IVoice : IType
	{
		/// <summary>
		/// Функция, реализующая издавание звуков
		/// </summary>
		/// <returns>Строка с указанием издаваемого звука</returns>
		string Speak();
	}
}

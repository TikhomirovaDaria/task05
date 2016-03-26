using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Интерфейс, определяющий единственную функцию Move
	/// Наследует интерфейс IType
	/// </summary>
	public interface IMotion : IType
	{
		/// <summary>
		/// Функция, реализующая движение
		/// </summary>
		/// <returns>Строка с указанием выполняемого движения</returns>
		string Move();
	}
}

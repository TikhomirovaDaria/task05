using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Интерфейс IType
	/// Гарантирует у наследников существование свойства <see = cref "type"/> 
	/// </summary>
	public interface IType
	{
		/// <summary>
		/// Свойство <see = cref "type"/>
		/// Предоставляет доступ на чтение к параметру <see = cref "type"/> 
		/// </summary>
		string type { get; }
	}
}

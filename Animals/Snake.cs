using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Змея
	/// Наследует абстрактный класс Animal
	/// </summary>
	public class Snake : Animal
	{
		/// <summary>
		/// Конструктор по умолчанию
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Snake"
		/// </summary>
		public Snake()
			: base()
		{
			type = "Snake";
		}
		/// <summary>
		/// Конструктор c параметрами
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Snake"
		/// </summary>
		public Snake(IMotion _motion, IVoice _voice)
			: base(_motion, _voice)
		{
			type = "Snake";
		}
		/// <summary>
		/// Определение абстрактного метода, который устанавливает список валидных моделей движения и издавания звуков
		/// для класса <see = cref "Snake"/>
		/// </summary>
		protected override void SetValids()
		{
			validMotion = new List<IMotion> { new Eat(), new Hunt(), new Sleep() };
			validVoice = new List<IVoice> { new KeepSilence(), new Hiss() };
		}
	}
}

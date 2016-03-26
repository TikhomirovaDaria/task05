using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Волк
	/// Наследует абстрактный класс Animal
	/// </summary>
	public class Wolf : Animal
	{
		/// <summary>
		/// Конструктор по умолчанию
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Wolf"
		/// </summary>
		public Wolf()
			: base()
		{
			type = "Wolf";
		}
		/// <summary>
		/// Конструктор c параметрами
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Wolf"
		/// </summary>
		public Wolf(IMotion _motion, IVoice _voice)
			: base(_motion, _voice)
		{
			type = "Wolf";
		}
		/// <summary>
		/// Определение абстрактного метода, который устанавливает список валидных моделей движения и издавания звуков
		/// для класса <see = cref "Wolf"/>
		/// </summary>
		protected override void SetValids()
		{
			validMotion = new List<IMotion> { new Eat(), new Run(), new Hunt(), new Sleep() };
			validVoice = new List<IVoice> { new Roar(), new KeepSilence(), new Howl() };
		}
	}
}

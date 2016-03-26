using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Рыба
	/// Наследует абстрактный класс Animal
	/// </summary>
	public class Fish : Animal
	{
		/// <summary>
		/// Конструктор по умолчанию
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Fish"
		/// </summary>
		public Fish()
			: base()
		{
			type = "Fish";
		}
		/// <summary>
		/// Конструктор c параметрами
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Fish"
		/// </summary>
		public Fish(IMotion _motion, IVoice _voice)
			: base(_motion, _voice)
		{
			type = "Fish";
		}

		/// <summary>
		/// Определение абстрактного метода, который устанавливает список валидных моделей движения и издавания звуков
		/// для класса <see = cref "Fish"/>
		/// </summary>
		protected override void SetValids()
		{
			validMotion = new List<IMotion> { new Eat(), new Sleep() };
			validVoice = new List<IVoice> { new KeepSilence() };
		}
	}
}

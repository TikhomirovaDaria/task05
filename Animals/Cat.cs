using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Кошка
	/// Наследует абстрактный класс Animal
	/// </summary>
	public class Cat : Animal
	{
		/// <summary>
		/// Конструктор по умолчанию
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Cat"
		/// </summary>
		public Cat()
			: base()
		{
			type = "Cat";
		}
		/// <summary>
		/// Конструктор c параметрами
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Cat"
		/// </summary>
		public Cat(IMotion _motion, IVoice _voice)
			: base(_motion, _voice)
		{
			type = "Cat";
		}

		/// <summary>
		/// Определение абстрактного метода, который устанавливает список валидных моделей движения и издавания звуков
		/// для класса <see = cref "Cat"/>
		/// </summary>
		protected override void SetValids()
		{
			validMotion = new List<IMotion> { new Eat(), new Hunt(), new Run(), new Sleep() };
			validVoice = new List<IVoice> { new Purr(), new KeepSilence(), new Hiss() };
		}
	}
}

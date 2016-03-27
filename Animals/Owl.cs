using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс Сова
	/// Наследует абстрактный класс Animal
	/// </summary>
	public class Owl : Animal
	{
		/// <summary>
		/// Конструктор по умолчанию
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Owl"
		/// </summary>
		public Owl()
			: base()
		{
			type = "Owl";
		}
		/// <summary>
		/// Конструктор c параметрами
		/// Вызывает аналогичный конструктор базового класса
		/// Определяет значение поля <see = cref "type"/>
		/// равным "Owl"
		/// </summary>
		public Owl(IMotion _motion, IVoice _voice)
			: base(_motion, _voice)
		{
			type = "Owl";
		}
		/// <summary>
		/// Определение абстрактного метода, который устанавливает список валидных моделей движения и издавания звуков
		/// для класса <see = cref "Owl"/>
		/// </summary>
		protected override void SetValids()
		{
			validMotion = new List<IMotion> { new Eat(), new Hunt(), new Fly(), new Sleep() };
			validVoice = new List<IVoice> { new KeepSilence(), new Hoot() };
		}
	}
}

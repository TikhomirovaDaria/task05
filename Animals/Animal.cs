using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Базовый класс для всех животных, представленных в зоопарке
	/// </summary>
	public abstract class Animal : IType
	{
		/// <summary>
		/// Содержит имя класса
		/// </summary>
		public string type { get; protected set; }
		/// <summary>
		/// Запуск генератора случайных чисел
		/// </summary>
		protected Random rand = new Random(Guid.NewGuid().GetHashCode());

		/// <summary>
		/// Свойство для работы с переменной <see = cref "motion"/>
		/// </summary>
		/// <value> Свойство позволяеет добавить/получить значение перемнной <see = cref "motion"/>
		/// В <see = cref "set"/> предусмотрено безопасное присваивание значения переменной <see = cref "motion"/>:
		/// если значение <see = cref "value"/> валидное - идет обычное присваивание, 
		/// в противном случае выбрасывается исключение <see = cref "ArgumentException"/>
		/// с указанием неверного параметра и свойства, где было сгенерировано исключене
		/// </value>
		protected IMotion Motion
		{
			get
			{
				return motion;
			}
			set
			{
				if (IsValid(value, validMotion) == false)
					throw new ArgumentException("in Motion: wrong Argument(motion)");
				else
					motion = value;
			}

		}
		/// <summary>
		/// Тип движения животного
		/// </summary>
		IMotion motion;
		/// <summary>
		/// Свойство для работы с переменной <see = cref "voice"/>
		/// </summary>
		/// <value> Свойство позволяеет добавить/получить значение перемнной <see = cref "voice"/>
		/// В <see = cref "set"/> предусмотрено безопасное присваивание значения переменной <see = cref "voice"/>:
		/// если значение <see = cref "value"/> валидное - идет обычное присваивание, 
		/// в противном случае выбрасывается исключение <see = cref "ArgumentException"/>
		/// с указанием неверного параметра и свойства, где было сгенерировано исключене
		/// </value>
		protected IVoice Voice
		{
			get
			{
				return voice;
			}
			set
			{
				if (IsValid(value, validVoice) == false)
					throw new ArgumentException("in Voice: wrong Argument(voice)");
				else
					voice = value;
			}
		}
		/// <summary>
		/// Тип издаваемого животным звука
		/// </summary>
		IVoice voice;

		/// <summary>
		/// Конструктор по умолчанию
		/// Определяет валидные модели движения и издавания звуков
		/// Задает случайные валидные значения полей <see = cref "motion"/> и <see = cref "voice"/>
		/// </summary>
		protected Animal()
		{
			SetValids();
			InitialBehaviour();
		}
		/// <summary>
		///  Конструктор с параметрами
		///  Определяет валидные модели движения и издавания звуков
		///  Присваивает полям <see = cref "motion"/> и <see = cref "voice"/>
		///  значения, переданные в качестве аргументов
		/// </summary>
		/// <param name="_motion">Параметр, значение которого присваивается полю <see = cref "motion"/></param>
		/// <param name="_voice">Параметр, значение которого присваивается полю <see = cref "voice"/></param>
		protected Animal(IMotion _motion, IVoice _voice)
		{
			SetValids();
			Creation(_motion, _voice);
		}

		/// <summary>
		/// Список валидных спосбов двжения
		/// Представлен в виде AutoProperty
		/// </summary>
		protected List<IMotion> validMotion { get; set; }
		/// <summary>
		/// Список валидных спосбов издавать звуки
		/// Представлен в виде AutoProperty
		/// </summary>
		protected List<IVoice> validVoice { get; set; }
		/// <summary>
		/// Generic метод. Проверяет валидность заданного параметра
		/// путем проверки его вхождения в список разрешенных типов
		/// </summary>
		/// <typeparam name="T">Принимает значения 
		/// <see = cref "IMotion"/> или <see = cref "IVoice"/></typeparam>
		/// <param name="arg">Введенный пользователем аргумент, валидность которого надо проверить</param>
		/// <param name="list">Список разрешенных типов</param>
		/// <returns></returns>
		protected bool IsValid<T>(T arg, List<T> list)
		{
			for (int i = 0; i < list.Count; i++)
				if (arg.GetType() == list[i].GetType())
					return true;
			return false;
		}

		/// <summary>
		/// Присваивает введенные пользователем значения
		/// полям <see = cref "motion"/> и <see = cref "voice"/>
		/// </summary>
		/// <param name="_motion">Значение для <see = cref "motion"/></param>
		/// <param name="_voice">Значение для <see = cref "voice"/></param>
		protected void Creation(IMotion _motion, IVoice _voice)
		{
			Motion = _motion;
			Voice = _voice;
		}
		/// <summary>
		/// Задает случайные валидные значения полей <see = cref "motion"/> и <see = cref "voice"/>
		/// </summary>
		protected void InitialBehaviour()
		{
			Motion = validMotion[rand.Next(0, validMotion.Count)];
			Voice = validVoice[rand.Next(0, validVoice.Count)];
		}
		/// <summary>
		/// Абстрактный метод, который устанавливает список валидных моделей движения и издавания звуков
		/// для каждого класса-животного
		/// </summary>
		protected abstract void SetValids();

		/// <summary>
		/// Переопределение стандартной функции ToString()
		/// </summary>
		/// <returns>Возвращает полную информацию о классе-животном 
		/// (Имя, Способ движния, Способ издавания звуков) в виде форматированной строки</returns>
		public override string ToString()
		{
			return string.Format("{0}:\t {1}.\t {2}.", type.ToString(), motion.Move(), voice.Speak());
		}
	}
}

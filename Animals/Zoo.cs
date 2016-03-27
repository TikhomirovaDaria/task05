using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	/// <summary>
	/// Класс имитирующий работу зопарка
	/// </summary>
	public class Zoo
	{
		/// <summary>
		/// Список животных в зоопарке
		/// </summary>
		private List<Animal> animals;
		/// <summary>
		/// Конструктор по умолчаию
		/// Создание экземпляра зоопарка
		/// Инициализация переменных <see = cref "KeyAddValid"/> и <see = cref "KeyAddAny"/> 
		/// типа <see = cref "Dictionary"/> для облегчния добавления животных разных видов
		/// Определение полного списка всевозможных вариантов Животных, их Действий, их Звуков
		/// </summary>
		public Zoo()
		{
			animals = new List<Animal>();

			InitKeyAddValid();
			InitKeyAddAny();

			allAnimals = new List<Animal> { new Cat(), new Fish(), new Owl(), new Snake(), new Wolf() };
			allMotions = new List<IMotion> { new Eat(), new Fly(), new Hunt(), new Run(), new Sleep() };
			allVoices = new List<IVoice> { new Hiss(), new Hoot(), new Howl(), new KeepSilence(), new Purr(), new Roar() };
		}

		/// <summary>
		/// Свойство предосавляющее возможность получить/записать
		/// полный список возможных животных
		/// </summary>
		public List<Animal> allAnimals { get; private set; }
		/// <summary>
		/// Свойство предосавляющее возможность получить/записать
		/// полный список возможных действий
		/// </summary>
		public List<IMotion> allMotions { get; private set; }
		/// <summary>
		/// Свойство предосавляющее возможность получить/записать
		/// полный список возможных звуков
		/// </summary>
		public List<IVoice> allVoices { get; private set; }

		/// <summary>
		/// Функция создания и определения экземпляра <see = cref "KeyAddValid"/>
		/// типа <see = cref "Dictionary"/> для облегчния добавления валидных случайных животных разных видов
		/// </summary>
		void InitKeyAddValid()
		{
			keyAddValid = new Dictionary<int, Action>();

			keyAddValid.Add(1, AddValid<Cat>);
			keyAddValid.Add(2, AddValid<Fish>);
			keyAddValid.Add(3, AddValid<Owl>);
			keyAddValid.Add(4, AddValid<Snake>);
			keyAddValid.Add(5, AddValid<Wolf>);
		}
		public Dictionary<int, Action> keyAddValid;

		/// <summary>
		/// Функция создания и определения экземпляра <see = cref "KeyAddAny"/>
		/// типа <see = cref "Dictionary"/> для облегчния добавления произвольных пользовательских животных разных видов
		/// </summary>
		void InitKeyAddAny()
		{
			keyAddAny = new Dictionary<int, Action<IMotion, IVoice>>();
			keyAddAny.Add(1, AddAny<Cat>);
			keyAddAny.Add(2, AddAny<Fish>);
			keyAddAny.Add(3, AddAny<Owl>);
			keyAddAny.Add(4, AddAny<Snake>);
			keyAddAny.Add(5, AddAny<Wolf>);
		}
		public Dictionary<int, Action<IMotion, IVoice>> keyAddAny;

		/// <summary>
		/// Добавляет заданное число произвольных валидных животных
		/// </summary>
		/// <param name="count">Число животных, которых надо добавить</param>
		public void AddRandom(int count)
		{
			Random rand = new Random();
			for (int i = 0; i < count; i++)
			{
				keyAddValid[rand.Next(1, keyAddValid.Count + 1)]();
			}
		}
		/// <summary>
		/// Generic метод
		/// Добавляет одно случайное животное типа T
		/// </summary>
		/// <typeparam name="T">Может принимать тип любого класса-животного</typeparam>
		private void AddValid<T>() where T : Animal, new()
		{
			animals.Add(new T());
		}
		/// <summary>
		/// Generic метод
		/// Добавляет одно пользовательское животное типа T
		/// </summary>
		/// <typeparam name="T">Может принимать тип любого класса-животного</typeparam>
		/// <param name="motion">Задает тип движения животного</param>
		/// <param name="voice">Задает тип издаваемых живтным звуков</param>
		private void AddAny<T>(IMotion motion, IVoice voice) where T : Animal, new()
		{
			object[] args = new object[] { motion, voice };
			try
			{
				animals.Add((T)Activator.CreateInstance(typeof(T), args));
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
		}

		/// <summary>
		/// Проведение опроса всех животных зоопарка
		/// </summary>
		/// <returns>список всех животных зоопарка
		/// с указанием их действия и издаваемого звука</returns>
		public List<string> ExamineZoo()
		{
			List<string> result = new List<string>();
			for (int i = 0; i < animals.Count; i++)
				result.Add(animals[i].ToString());
			return result;
		}

		/// <summary>
		/// Конвертрует списки всех животных <see = cref "allAnimals"/>
		/// всех их возможных действий <see = cref "allMotions"/>
		/// и всего спектра издаваемх ими звуков <see = cref "allVoices"/>
		/// в списоки строк с указанием соответственно всех животных,
		/// всех их движений и всех издаваемых ими звуков
		/// </summary>
		/// <typeparam name="T">Animal, IMotion, IVoice</typeparam>
		/// <param name="allItems">Один из списков <see = cref "allAnimals"/>,
		/// <see = cref "allMotions"/>, <see = cref "allVoices"/></param>
		/// <returns>Возвращает кнвертированный список строк</returns>
		public List<string> ToStringList<T>(List<T> allItems) where T : IType
		{
			List<string> stringList = new List<string>();

			for (int i = 0; i < allItems.Count; i++)
				stringList.Add(allItems[i].type);

			return stringList;
		}

		/// <summary>
		/// Проверяет зоопарк на пустоту
		/// </summary>
		/// <returns>False - в зоопарке есть хотя бы одно животное, True - в противном случае</returns>
		public bool IsEmpty()
		{
			if (animals.Count == 0)
				return true;
			return false;
		}
	}
}

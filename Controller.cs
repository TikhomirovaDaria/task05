using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
	class Controller
	{
		/// <summary>
		/// Создние экземпляр зоопарка, с которым проводится работа
		/// </summary>
		Zoo zoo = new Zoo();
		/// <summary>
		/// Инициализация лога
		/// </summary>
		Logs log = new Logs();

		/// <summary>
		/// Функция для введения числа удовлетворяющего следующим параметрам:
		///		1) целое
		///		2) меньше <see = cref "maxVal"/>
		///		3) больше <see = cref "minVal"/>
		/// </summary>
		/// <param name="text">Приглашение для ввода</param>
		/// <param name="minVal">Нижний порог вводимого числа (не включается)</param>
		/// <param name="maxVal">Верхний порог вводимого числа (не включается)</param>
		/// <returns>Целое число, удовлетворяющее заданным параметрам</returns>
		int InputNumber(string text, int minVal = 1, int maxVal = Int32.MaxValue)
		{
			int number;
			while (true)
			{
				Console.Write(text);
				if (Int32.TryParse(Console.ReadLine(), out number)
					&& number > minVal && number < maxVal)
					return number;
				Console.WriteLine("Wrong input\n");
			}
		}
		/// <summary>
		/// Вывод на экран меню
		/// </summary>
		/// <param name="lines">Элементы списка меню</param>
		/// <param name="esc">Указание, если ли взможность выхода по ESC</param>
		void PrintMenu(List<string> lines, bool esc)
		{
			Console.Clear();

			Console.WriteLine("Press:");
			for (int i = 0; i < lines.Count; i++)
				Console.WriteLine(string.Format("  {0} - {1}", i + 1, lines[i]));
			if (esc)
				Console.WriteLine("  ESC - exit");

			Console.Write("Choice: ");
		}

		/// <summary>
		/// Добавление пользователем животного(ых) с указанием 
		/// выполняемого им действия и издаваемого звука
		/// </summary>
		void AddUser()
		{
			List<string>[] all = new List<string>[3];
			all[0] = zoo.ToStringList(zoo.allAnimals);
			all[1] = zoo.ToStringList(zoo.allMotions);
			all[2] = zoo.ToStringList(zoo.allVoices);

			int[] choice = new int[3];

			do
			{
				for (int i = 0; i < 3; i++)
				{
					PrintMenu(all[i], false);							// требуется именно InputNumber с его ReadLine, а не ReadKey
					choice[i] = InputNumber("", 0, all[i].Count + 1);	// тк животных и моделей их поведения может быть куда больше 10							
				}

				try
				{
					zoo.keyAddAny[choice[0]](zoo.allMotions[choice[1] - 1], zoo.allVoices[choice[2] - 1]);
				}
				catch (ArgumentException ex)
				{
					log.MakeLog(ex.Message);
					Console.WriteLine("\n\n{0}", ex.Message);
					Console.Write("You can try again or ");
				}
				Console.Write("Press Esc to exit");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
		/// <summary>
		/// Добавление случайных животного(ых) с валидным поведением
		/// </summary>
		void AddRandom()
		{
			Console.Clear();

			int number = InputNumber("Enter nuber of animals to Add: ");
			zoo.AddRandom(number);

			Console.WriteLine("Animals have been added");
			Console.ReadKey();
		}
		/// <summary>
		/// Опрос зоопарка
		/// Каждое животное предоставляет сведение о собственном типе,
		/// выполняемом движении и издаваемом звуке
		/// </summary>
		void Examine()
		{
			Console.Clear();

			if (zoo.IsEmpty())
			{
				Console.WriteLine("Zoo is empty");
				Console.ReadKey();
				return;
			}

			List<string> result = zoo.ExamineZoo();
			for (int i = 0; i < result.Count; i++)
			{
				Console.WriteLine(result[i]);
			}
			Console.ReadKey();
		}

		/// <summary>
		/// Определение объекта типа <see = cref "Dictionary<char, Action>"/>,
		/// отвечающего за возможные варианты действий, выбираемых из меню
		/// </summary>
		/// <returns>Объект типа <see = cref "Dictionary<char, Action>"/></returns>
		Dictionary<char, Action> InitKeyMenu()
		{
			Dictionary<char, Action> keyMenu = new Dictionary<char, Action>();
			keyMenu.Add('1', AddUser);
			keyMenu.Add('2', AddRandom);
			keyMenu.Add('3', Examine);

			return keyMenu;
		}
		/// <summary>
		/// Логика работы меню, которое видит пользовтель  
		/// </summary>
		public void Menu()
		{
			ConsoleKeyInfo key;
			List<string> text = new List<string> { "Add animals by user", "Add animals randomly", "Examine Zoo" };

			Dictionary<char, Action> keyMenu = InitKeyMenu();

			while (true)
			{
				PrintMenu(text, true);
				key = Console.ReadKey();

				if (keyMenu.ContainsKey(key.KeyChar))
					keyMenu[key.KeyChar]();

				else if (key.Key == ConsoleKey.Escape)
					return;

				else
				{
					Console.Write("\n\nWrong input");
					Console.ReadKey();
				}
			}
		}
	}
}
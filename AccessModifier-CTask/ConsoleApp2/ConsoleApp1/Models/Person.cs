namespace ConsoleApp1.Models
{
	internal class Person
	{
		private string _name;
		private string _surname;
		private int _age;

		//public string Name
		//{
		//	get
		//	{
		//		return _name;
		//	}
		//	set
		//	{
		//		if (!String.IsNullOrWhiteSpace(value) && value.Length >= 2)
		//		{
		//			_name = value;
		//		}
		//		else
		//		{
		//			Console.WriteLine("Adin uzunlugu kicikdir!!!");
		//		}
		//	}
		//}

		//public string Surname
		//{
		//	get
		//	{
		//		return _surname;
		//	}
		//	set
		//	{
		//		if (!String.IsNullOrWhiteSpace(value))
		//		{
		//			_surname = value;
		//		}

		//		else
		//		{
		//			Console.WriteLine("Soyadin uzunlugu kicikdir!!!");
		//		}
		//	}
		//}

		//public int Age
		//{
		//	get
		//	{
		//		return _age;
		//	}
		//	set
		//	{
		//		if (value >= 16)
		//		{
		//			_age = value;
		//		}

		//		else
		//		{
		//			Console.WriteLine("Yash Balacadir!!!");
		//		}
		//	}
		//}

		//public string FullName
		//{
		//	get => Name + " " + Surname + " " + Age;
		//}

		public string GetName() => _name;

		public void SetName(string name)
		{
			if (!String.IsNullOrWhiteSpace(name) && name.Length >= 2)
			{
				_name = name;
			}
			else
			{
				Console.WriteLine("Ad uzunlugu kicikdir!!!");
			}
		}
		public string GetSurname() => _surname;
		public void SetSurname(string surname)
		{
			if (!String.IsNullOrWhiteSpace(surname))
			{
				_surname = surname;
			}
			else
			{
				Console.WriteLine("Soyad bosdur!!!");
			}
		}
		public int GetAge() => _age;
		public void SetAge(int age)
		{
			if (age >= 16)
			{
				_age = age;
			}
			else
			{
				Console.WriteLine("Yas kicikdir!!!");
			}
		}

		public string FullName
		{
			get => GetName() + " " + GetSurname() + " " + GetAge();
		}


	}
}
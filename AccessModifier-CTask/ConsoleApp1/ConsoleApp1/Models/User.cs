namespace ConsoleApp1.Models
{
	internal class User
	{
		private string _username;
		private string _password;

		public string Username
		{
			get
			{
				if (_username == null)
				{
					_username = "Input is null...";
				}
				return _username;
			}
			set
			{
				if (!String.IsNullOrWhiteSpace(value) && value.Length >= 4)
				{
					_username = value;
				}
				else
				{
					Console.WriteLine("Wrong input!!!");
				}
			}
		}

		public bool HasDigit(string str) 
		{
            foreach (var c in str)
            {
                if (char.IsDigit(c))
                {
					return true;
                }
            }
				return false;
        }
		public bool IsUpper(string str)
		{
			foreach (var c in str)
			{
				if (char.IsUpper(c))
				{
					return true;
				}
			}
			return false;
		}
		public bool IsLower(string str)
		{
			foreach (var c in str)
			{
				if (char.IsLower(c))
				{
					return true;
				}
			}
			return false;
		}
		public string Password
		{
			get
			{
				if (_password == null)
				{
					_password = "Input is null...";
				}
				return _password;
			}
			set
			{
				if (!String.IsNullOrWhiteSpace(value) && value.Length >= 6 && IsUpper(value) && IsLower(value) && HasDigit(value))
				{
					_password = value;
				}

                else
                {
                    Console.WriteLine("Wrong input!!!");
                }
            }
		}

		public string FullName
		{
			get => Username + " " + Password;
		}
	}
}

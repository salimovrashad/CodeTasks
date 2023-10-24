using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Student
	{
		public string Name;
		public string Surname;
		public string Group;
		public int Age;

		public Student(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}

		public Student(string name, string surname, string group, int age) : this(name, surname) 
		{
			Group = group;
			Age = age;
		}
	}
}

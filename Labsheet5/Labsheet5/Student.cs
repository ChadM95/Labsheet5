using System;
namespace Labsheet5
{
	public class Student
	{
		public string Name { get; set; }
		public string Course { get; set; }
		public int GPA { get; set; }


		public Student(string name, string course, int gpa)
		{
			Name = name;
			Course = course;
			GPA = gpa;
		}
	}
}


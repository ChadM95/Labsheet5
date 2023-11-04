using System;
namespace Labsheet5
{
	public class Student
	{
		//properties
		public string Name { get; set; }
		public string Course { get; set; }
		public int GPA { get; set; }

		//constructor
		public Student(string name, string course, int gpa)
		{
			Name = name;
			Course = course;
			GPA = gpa;
		}

		//ToString method override
        public override string ToString()
        {
			return $"{Name} {Course} {GPA}";
        }

		//Regular Method
		public static int AdjustGPA(int percentage)
		{
			return GPA (percentage / 100); 
		}
    }
}


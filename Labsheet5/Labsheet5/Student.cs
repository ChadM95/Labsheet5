using System;
namespace Labsheet5
{
	public class Student
	{
		//properties
		public string Name { get; set; }
		public string Course { get; set; }
		public double GPA { get; set; }

		//constructor
		public Student(string name, string course, double gpa)
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

		//Method
		public void AdjustGPA(double percentage)
		{
			GPA = GPA + (1 + percentage);
		}
    }
}


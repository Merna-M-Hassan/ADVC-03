using System.Drawing;

namespace Assignment_12_C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)Student Grade Manager

            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //Print the collection, Count, first and last grade
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            ConsoleHelper.PrintGrades("The Grades List", grades);
            Console.WriteLine($"Number of items in the list: {grades.Count}");
            Console.WriteLine($"The first item in the list: {grades[0]}");
            Console.WriteLine($"The last item in the list: {grades[^1]}");
            Console.WriteLine();

            //Sort the grades ascending, then print
            grades.Sort();
            ConsoleHelper.PrintGrades("After sort", grades);
            Console.WriteLine();


            //Get the first grade above 90
            int grade1A = grades.Find(x => x > 90);
            Console.WriteLine($"The first grade above 90 is: {grade1A}");
            Console.WriteLine();

            //Get all grades below 75 (failing grades)
            List<int> failGrades = grades.FindAll(x => x < 75);
            //foreach(int grade in failGrades)
            //    Console.WriteLine($"{grade}");
            ConsoleHelper.PrintGrades("The Fail Grades", failGrades);
            Console.WriteLine();


            //Remove all failing grades (below 75)
            grades.RemoveAll(x => x < 75);
            ConsoleHelper.PrintGrades("After remove below 75", grades);
            Console.WriteLine() ;   

            //Check if any grade equals 100
            Console.WriteLine($"- Is there is grade equals 100? = {grades.Contains(100)}");
            Console.WriteLine();


            //Create a List<string> where each grade becomes "Grade: X"
            List<string> Grades = grades.ConvertAll(g => $"Grade: {g}");
            ConsoleHelper.PrintGrades("All Grades", Grades);

            #endregion
        }
    }
}

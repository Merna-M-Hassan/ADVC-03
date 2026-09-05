using System.Drawing;

namespace Assignment_12_C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)Student Grade Manager

            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            ////Print the collection, Count, first and last grade
            ////foreach (int grade in grades)
            ////{
            ////    Console.WriteLine(grade);
            ////}
            //ConsoleHelper.PrintGrades("The Grades List", grades);
            //Console.WriteLine($"Number of items in the list: {grades.Count}");
            //Console.WriteLine($"The first item in the list: {grades[0]}");
            //Console.WriteLine($"The last item in the list: {grades[^1]}");
            //Console.WriteLine();

            ////Sort the grades ascending, then print
            //grades.Sort();
            //ConsoleHelper.PrintGrades("After sort", grades);
            //Console.WriteLine();


            ////Get the first grade above 90
            //int grade1A = grades.Find(x => x > 90);
            //Console.WriteLine($"The first grade above 90 is: {grade1A}");
            //Console.WriteLine();

            ////Get all grades below 75 (failing grades)
            //List<int> failGrades = grades.FindAll(x => x < 75);
            ////foreach(int grade in failGrades)
            ////    Console.WriteLine($"{grade}");
            //ConsoleHelper.PrintGrades("The Fail Grades", failGrades);
            //Console.WriteLine();


            ////Remove all failing grades (below 75)
            //grades.RemoveAll(x => x < 75);
            //ConsoleHelper.PrintGrades("After remove below 75", grades);
            //Console.WriteLine() ;   

            ////Check if any grade equals 100
            //Console.WriteLine($"- Is there is grade equals 100? = {grades.Contains(100)}");
            //Console.WriteLine();


            ////Create a List<string> where each grade becomes "Grade: X"
            //List<string> Grades = grades.ConvertAll(g => $"Grade: {g}");
            //ConsoleHelper.PrintGrades("All Grades", Grades);

            #endregion

            #region Q2) Leaderboard

            //// Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            ////This is an empty dictionary. 
            //// The array of bucket = zero. With adding the first key&value pair, the array of bucket will be = 3 (nearest prime number).
            //Dictionary<int, string> leaderboard = new()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"},
            //};

            ////Print all entries (they should be sorted by score automatically)
            ////foreach (KeyValuePair<int, string> pair in leaderboard)
            ////{
            ////    Console.WriteLine(pair);
            ////}
            //ConsoleHelper.PrintDictionary<int, string>("Scores ", leaderboard);
            //Console.WriteLine();


            ////Access the first key and first value
            //var firstEntry = leaderboard.First();
            //Console.WriteLine($"First Key: {firstEntry.Key}");
            //Console.WriteLine($"First Value: {firstEntry.Value}");
            //Console.WriteLine();

            ////Check if score 500 exists
            ////if (leaderboard.ContainsKey(500))
            ////    Console.WriteLine("The player exists.");

            ////else
            ////    Console.WriteLine("Not Found");
            //string? check = leaderboard.GetValueOrDefault(500);
            //Console.WriteLine($"Palyer {check} exists");
            //Console.WriteLine();


            ////Safely get the player with score 999
            ////if(leaderboard.ContainsKey(900))
            ////    Console.WriteLine(leaderboard[900]);

            ////else
            ////    Console.WriteLine("Not Found");
            ////Console.WriteLine();
            //bool result = leaderboard.TryGetValue(999, out string? value);
            //Console.WriteLine(result);
            //Console.WriteLine(value ?? "null");
            //Console.WriteLine();

            ////Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);
            //ConsoleHelper.PrintDictionary("After remove", leaderboard);

            #endregion

            #region Q3) Phone Book
            ////Create a Collection with 4 contacts (name → phone number)
            //Dictionary<string, string> phoneBook = new()
            //{
            //    { "Ahmed", "555-1234" },
            //    { "Sara", "555-5678" },
            //    { "Ali", "555-9012" },
            //    { "Mona", "555-3456" }
            //};

            ////Add a new contact using [] syntax (add or update)
            //phoneBook["Khaled"] = "12356885";
            ////update
            //phoneBook["Ali"] = "55569547";
            //ConsoleHelper.PrintDictionary("After modify", phoneBook);
            //Console.WriteLine();


            ////Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phoneBook.Add("Sara", "555-7777");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //Console.WriteLine();


            ////Try adding a duplicate using .TryAdd() — print whether it succeeded
            //bool added = phoneBook.TryAdd("Sara", "555-8888");
            //Console.WriteLine($"Was Sara added? {added}");
            //Console.WriteLine();    
            //added = phoneBook.TryAdd("Lili", "45322255");
            //Console.WriteLine($"Was Nadia added? {added}");
            //Console.WriteLine();

            ////Search for a contact that doesn’t exist
            //if (phoneBook.ContainsKey("Sami"))
            //    Console.WriteLine("The name exists.");

            //else
            //    Console.WriteLine("Not exist");
            //Console.WriteLine();

            ////Get a contact with a fallback of "Not Found"
            //if (phoneBook.TryGetValue("Shady", out string? value))
            //{
            //    Console.WriteLine($"{value}");
            //}
            //else
            //{
            //    Console.WriteLine($"Shady Not Found");
            //}
            //Console.WriteLine();

            ////Print all Keys on one line, then all Values on another line
            //Console.WriteLine("Keys:   " + string.Join(", ", phoneBook.Keys));
            //Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion

            #region Q4) Unique Email Validator

            //Create a HashSet<string> with a case-insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            HashSet<string> email = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //Add emails:
            bool email01 = email.Add("ahmed@test.com");
            bool email02 = email.Add("AHMED@test.com");      
            bool email03 = email.Add("sara@test.com");
            bool email04 = email.Add("Sara@Test.Com");

            //Print Count — how many are actually stored? Explain why.
            Console.WriteLine($"{email.Count}");
            //output: only two emails are printed. Because the upper case and lower case are considered the same (insensitive case).
            Console.WriteLine();

            //Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            HashSet<int> setA = [ 1, 2, 3, 4, 5 ];
            HashSet<int> setB = [ 4, 5, 6, 7, 8 ];

            //Print the result of: UnionWith, IntersectWith, ExceptWith

            // UnionWith - combines both sets (all unique elements)
            //setA.UnionWith(setB);
            //ConsoleHelper.PrintHashSet("A Unionwith", setA);

            // IntersectWith - only elements present in both sets
            //setA.IntersectWith(setB);
            //ConsoleHelper.PrintHashSet("A IntersectWith", setA);

            // ExceptWith - elements in A that are not in B
            //setA.ExceptWith(setB);
            //ConsoleHelper.PrintHashSet("A ExceptWith", setA);

            //Use IsSubsetOf to check if {1,2} is a subset of Set A
            HashSet<int> setC = [1, 2];
            bool result = setC.IsSubsetOf(setA);
            Console.WriteLine(result);
            #endregion
        }
    }
}

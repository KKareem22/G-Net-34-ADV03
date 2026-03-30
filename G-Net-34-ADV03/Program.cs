namespace G_Net_34_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Helper.Print("Grades", grades);
            //Console.WriteLine($"Count : {grades.Count}");
            //Console.WriteLine($"The First grade in grades ={grades.First()}");
            //Console.WriteLine($"The Last grade in grades ={grades.Last()}");
            //grades.Sort();
            //Helper.Print("Sorted Grades Ascending", grades);
            //Console.WriteLine($"The first grade above 90 ={grades.Find(x=>x>90)}");
            //List<int> failingGrades = grades.FindAll(x => x < 75);
            //Helper.Print("Failing Grades", failingGrades);
            //grades.RemoveAll(x => x < 75);
            //bool FullMarksExist = grades.Exists(x => x == 100);
            //Console.WriteLine($"Is there any grade with full marks (100) ? {FullMarksExist}");
            //List<string> FormattedGrades = new();
            //foreach(var grade in grades)
            //{
            //    string item = $"Grade : {grade}";
            //    FormattedGrades.Add(item);
            //}
            //FormattedGrades.ForEach(x => Console.WriteLine(x));

            #endregion
            #region Q02
            //SortedList<int, string> Players = new();
            //Players.Add(500, "Ahmed");
            //Players.Add(200, "Sara");
            //Players.Add(800, "Ali");
            //Players.Add(350, "Mona");
            //Helper.Print("Players", Players);
            //Console.WriteLine($"The first element in sorted list ->{Players.First()}");
            //Console.WriteLine($"The last element in sorted list ->{Players.Last()}");
            //Console.WriteLine($"Is there any score equal (500)? {Players.ContainsKey(500)}");
            //if(Players.ContainsKey(999))
            //{
            //    Console.WriteLine($"The player with score 999 is {Players[999]}");
            //}
            //else
            //{
            //    Console.WriteLine($"There is no player with score 999");
            //}
            //Players.Remove(200);
            //Helper.Print("Players after removing score 200", Players);
            #endregion
            #region Q03
           // Dictionary<string, string> PhoneBook = new();
           // PhoneBook.Add("Alice", "123-456-7890");
           // PhoneBook.Add("Bob", "987-654-3210");
           // PhoneBook.Add("Charlie", "555-555-5555");
           // PhoneBook.Add("Kareem", "551-666-4535");
           // Helper.PrintDictionary("Phone Book", PhoneBook);
           // PhoneBook["Zaid"] = "111-111-1111";// Add Zaid
           //// Helper.Print("Phone Book after updating Alice's number", PhoneBook);
           //try
           // {
           //     PhoneBook.Add("Ali", "222-222-2222");
           //     PhoneBook.Add("Ali", "222-222-2222");
           // }
           // catch (ArgumentException ex)
           // {
           //     Console.WriteLine($"Error: {ex.Message}");
           // }

           // Helper.PrintDictionary("Phone Book after adding Ali", PhoneBook);

           // bool Result01=PhoneBook.TryAdd("Rawan", "333-333-3333");
           // Console.WriteLine($"Trying to add Rawan : {Result01}");
           // bool Result02 = PhoneBook.TryAdd("Rawan", "333-333-3333");
           // Console.WriteLine($"Trying to add Rawan again : {Result02}");

           // if (PhoneBook.ContainsKey("Bale"))
           // {
           //     Console.WriteLine($"Bale's number is {PhoneBook["Bale"]}");
           // }
           // else
           // {
           //     Console.WriteLine($"There is no contact named Bale in the phone book.");
           // }
           // Console.WriteLine(PhoneBook.GetValueOrDefault("Eman", "Not Found"));//Not Found is the default value if Eman is not found in the dictionary

           // Console.WriteLine(new string('_',15));
           // Console.WriteLine("____Keys____");
           // foreach (var key in PhoneBook.Keys)
           // {
           //     Console.Write("  "+key);
           // }
           // Console.WriteLine("\n____Values____");
           // foreach (var value in PhoneBook.Values)
           // {
           //     Console.Write("  "+value);
           // }
           // Console.WriteLine("\n"+new string('_', 15));

            #endregion



        }
    }
}

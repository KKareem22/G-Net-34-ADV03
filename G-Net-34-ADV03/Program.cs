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
            #region Q04
            //HashSet<string> EmailValidator = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //EmailValidator.Add("ahmed@test.com");
            //EmailValidator.Add("Ahmed@test.com");
            //EmailValidator.Add("sara@test.com");
            //EmailValidator.Add("Sara@Test.com");
            //Console.WriteLine($"Count : {EmailValidator.Count}");//Count =2,Why? Because Only 2 unique emails due to case-insensitive comparison

            //HashSet<int> SetA = [1,2, 3, 4, 5];
            //HashSet<int> SetB = [4, 5, 6, 7, 8];
            //Helper.Print("SetA", SetA);
            //Helper.Print("SetB", SetB);
            //// Union
            //HashSet<int> Union = new(SetA);
            //Union.UnionWith(SetB);
            //Helper.Print("Union of SetA and SetB", Union);
            //// Intersection
            //HashSet<int> Intersection = new(SetA);
            //Intersection.IntersectWith(SetB);
            //Helper.Print("Intersection of SetA and SetB", Intersection);
            //// Difference
            //HashSet<int> Difference = new(SetA);
            //Difference.ExceptWith(SetB);
            //Helper.Print("Difference of SetA and SetB (SetA - SetB)", Difference);

            //HashSet<int> subset = [1, 2];
            //Console.WriteLine($"Is subset a subset of SetA ? {subset.IsSubsetOf(SetA)}");
            #endregion
            #region Q05
            //Queue<string> documents = new(5);
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");
            //Helper.PrintQueue("Documents",documents);

            //documents.TryPeek(out string? CurrentPeek);
            //Console.WriteLine($"Peek :{CurrentPeek}");
            //while(documents.Count>0)
            //{
            //    string doc = documents.Dequeue();
            //    Console.WriteLine($"Processing document : {doc}");
            //}
            //Console.WriteLine();
            ////documents.Dequeue();// This will throw an InvalidOperationException because the queue is empty
            //documents.TryDequeue(out string? result);
            //Console.WriteLine(result??"Null");// This will print "Null" because the queue is empty and TryDequeue returns false, setting result to null.
            #endregion

        }
    }
}

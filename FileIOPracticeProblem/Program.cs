namespace FileIOPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Write to text file\n2.Read from text file\n3.Write to CSV file\n4.Read from CSV file\n5.Write to JSON file\n6.Read from JSON file\n7.Exit");
            TextFile textFile = new TextFile();
            CSVFile csvFile = new CSVFile();
            JsonFile jsonFile = new JsonFile();
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        textFile.WriteToTextFile();
                        break;
                    case 2:
                        textFile.ReadFromTextFile();
                        break;
                    case 3:
                        csvFile.WriteToCSVFile();
                        break;
                    case 4:
                        csvFile.ReadFromCSVFile();
                        break;
                    case 5:
                        jsonFile.WriteToJsonFile();
                        break;
                    case 6:
                        jsonFile.ReadFromJsonFile();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    case 8:
                        loopAgain = false;
                        break;
                }
            }

        }
    }
}
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace FileIOPracticeProblem
{
    internal class CSVFile
    {
        public void WriteToCSVFile()//int Id, string Name, string Address, int Age
        {
            Details details = new Details();
            List<Details> detailsList = new List<Details>
            {
                new Details { Id = 1, Name = "Shreyas", Address = "Sangli", Age = 23 },
                new Details { Id = 2, Name = "Shubham", Address = "Vita", Age = 25 },
            };

            string csvPath = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\File.csv";

            using (var writer = new StreamWriter(csvPath))
            using (var csv = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(detailsList);
            }

            Console.WriteLine("CSV file written successfully.");
        }

        public void ReadFromCSVFile()
        {
            string filePath = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\File.csv";
            using (StreamReader reader = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<Details>();

                foreach (var record in records)
                {
                    Console.WriteLine($"Id: {record.Id}, Name: {record.Name}, Address: {record.Address}, Age: {record.Age}");
                }
            }
        }
    }
}

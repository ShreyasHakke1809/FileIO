namespace FileIOPracticeProblem
{
    internal class TextFile
    {
        public void WriteToTextFile()
        {
            Details details = new Details();
            List<Details> detailsList = new List<Details>
            {
                new Details { Id = 1, Name = "Shreyas", Address = "Sangli", Age = 23 },
                new Details { Id = 2, Name = "Shubham", Address = "Vita", Age = 25 },
            };
            string path = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\TextFil.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var contact in detailsList)
                {
                    writer.WriteLine($"Id: {contact.Id}");
                    writer.WriteLine($"First Name: {contact.Name}");
                    writer.WriteLine($"Address: {contact.Address}");
                    writer.WriteLine($"Age: {contact.Age}");
                }
            }
            Console.WriteLine($"Address book data written to {path}.");
        }
        public void ReadFromTextFile()
        {
            string path = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\TextFil.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}

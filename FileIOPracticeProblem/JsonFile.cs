using Newtonsoft.Json;

namespace FileIOPracticeProblem
{
    internal class JsonFile
    {
        public void WriteToJsonFile()
        {
            Details details = new Details();
            List<Details> detailsList = new List<Details>
            {
                new Details { Id = 1, Name = "Shreyas", Address = "Sangli", Age = 23 },
                new Details { Id = 2, Name = "Shubham", Address = "Vita", Age = 25 },
            };
            string jsonPath = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\Fiile.json";


            string jsonData = JsonConvert.SerializeObject(detailsList);
            File.WriteAllText(jsonPath, jsonData);


            Console.WriteLine("Write the addressBook with person contact as JSON file is Successfull");
        }
        public void ReadFromJsonFile()
        {
            string jsonPath = @"C:\Users\shrey\source\repos\FileIOPracticeProblem\FileIOPracticeProblem\Fiile.json";
            string jsonData = File.ReadAllText(jsonPath);
            var jsonResult = JsonConvert.DeserializeObject<List<Details>>(jsonData).ToList();
            Console.WriteLine("Reading from Json file");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

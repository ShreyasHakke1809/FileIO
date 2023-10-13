namespace FileIOPracticeProblem
{
    internal class Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id:{Id},Name: {Name}, Address: {Address},Age: {Age}";
        }

        /*public Details(int Id, string Name, string Address, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
        }*/
    }
}

namespace SHDMS
{
    public class Manufacturer 
    {
        public string Name { get; }
        public string Country { get; }
      

        public Manufacturer(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public  string GetInfo()
        {
            return $"{Name}" + $"{Country}"; 
        }

    }
}
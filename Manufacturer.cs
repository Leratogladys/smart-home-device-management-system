namespace SHDMS
{
    public class Manufacturer 
    {
        public string Name { get; }
        public string Country { get; }

        public Manufacturer ()
        {
            Name = "";
            Country = "";
        }
      

        public Manufacturer(string name, string country)
        {
            Name = name;
            Country = country;
        }

        Manufacturer philips = new Manufacturer("Philips Hue", "Netherlands");

        Manufacturer lifx = new Manufacturer("LIFX", "Australia");

        Manufacturer nest = new Manufacturer("Google Nest", "USA");

        Manufacturer ecobee = new Manufacturer("Ecobee", "Canada");

        Manufacturer yale = new Manufacturer("Yale Smart Locks", "UK");

        Manufacturer august = new Manufacturer("August Home", "USA");

        Manufacturer nanoleaf = new Manufacturer("Nanoleaf", "Canada");

        public  string GetInfo()
        {
            return $"{Name}" + $"{Country}"; 
        }

    }
}
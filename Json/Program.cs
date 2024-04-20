namespace Json
{
    public struct Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }

    internal class Program
    {        
        public static List<Human> humans = new List<Human>();

        public static void CreateHumans()
        {
            humans.Append<Human>(new Human { 
                FirstName="Mohsen",
                LastName="Yazdandust",
                NickName="themohsen",
                Age=23,
                Gender='M',
            });

            humans.Append<Human>(new Human
            {
                FirstName = "Abolfazl",
                LastName = "Navehosseini",
                NickName = "Abolo",
                Age = 20,
                Gender = 'M',
            });

            humans.Append<Human>(new Human
            {
                FirstName = "Javad",
                LastName = "Bayrami",
                NickName = "Javadi",
                Age = 23,
                Gender = 'M',
            });
        }
        static void Main(string[] args)
        {
            CreateHumans();
        }
    }
}
using Newtonsoft.Json;

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
        public static string path = "humans.json";

        public static void CreateHumans()
        {
            humans.Add(new Human { 
                FirstName="Mohsen",
                LastName="Yazdandust",
                NickName="themohsen",
                Age=23,
                Gender='M',
            });

            humans.Add(new Human
            {
                FirstName = "Abolfazl",
                LastName = "Navehosseini",
                NickName = "Abolo",
                Age = 20,
                Gender = 'M',
            });

            humans.Add(new Human
            {
                FirstName = "Javad",
                LastName = "Bayrami",
                NickName = "Javadi",
                Age = 23,
                Gender = 'M',
            });

        }

        static void CreateJson()
        {
            File.Open(path, FileMode.OpenOrCreate).Close();

            string json = System.Text.Json.JsonSerializer.Serialize(humans);
            Console.WriteLine(json);
            Console.WriteLine(humans.Count());
            File.WriteAllText(path, json);
        }

        static List<Human> ReadBackJson()
        {
            string json;

            if (File.Exists(path))
                json = File.ReadAllText(path);
            else
                json = "[]";

            List<Human> fileData = JsonConvert.DeserializeObject<List<Human>>(json);

            return fileData;
        }
        static void Main(string[] args)
        {
            CreateHumans();
            CreateJson();

            List<Human> fileData = ReadBackJson();
            Console.WriteLine(fileData[0].NickName);
        }
    }
}
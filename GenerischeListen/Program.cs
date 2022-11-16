namespace GenerischeListen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Städteliste = new List<string>();

            Städteliste.Add("Hamburg");
            Städteliste.Add("Berlin");
            Städteliste.Add("München");
            Städteliste.Add("Köln");
            Städteliste.Add("Dresden");
            Städteliste.Add("Düsseldorf");

            Console.WriteLine(Städteliste.Count);

            Console.WriteLine(Städteliste[3]);

            Städteliste[3] = "Dortmund";
            Console.WriteLine(Städteliste[3]);

            Städteliste.Remove("München");

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }


            Dictionary<string, int> Dict = new Dictionary<string, int>();

            Dict.Add("Hallo", 12);
            Dict.Add("Ahoj", 456);
            Dict.Add("Ciao", -45);
            Dict.Add("Moin", 0);

            Console.WriteLine(Dict["Ciao"]);

            foreach (var item in Dict)
            {
                Console.WriteLine(item.Key + ": " +item.Value);
            }
        }
    }
}
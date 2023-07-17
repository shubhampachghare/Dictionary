namespace Dictionary289
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            Program obj = new Program();
            obj.CreateDictionary();
        }

        public void CreateDictionary()
        {
            Dictionary<string, Int16> IdnRoll = new Dictionary<string, Int16>();
            IdnRoll.Add("Shubham ", 201);
            IdnRoll.Add("Tanuj", 301);
            IdnRoll.Add("Vishal", 401);
            IdnRoll.Add("Shruti", 501);
            IdnRoll.Add("Kishor", 601);
            Console.WriteLine("------Student Name And Roll No------");
            foreach (KeyValuePair<string, Int16> ID in IdnRoll)
            {
                Console.WriteLine("Name: {0}, Roll: {1}", ID.Key, ID.Value);
            }
        }
    }
}
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A a = new A();
            a.a();

            B b = new B();
            b.b();

            C c = new C();
            c.c();
            
            Console.ReadLine(); */

            C c = new C();
            c.a();
            c.b();
            c.c();

            Console.WriteLine();

            List<Person> list = new List<Person>();
            Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 3500);
            Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 3450);
            Student ollie = new Student("Ollie Welles", "6381 Hollywood Blvd. Los Angeles 90028");

            Console.WriteLine(ada.Show());
            Console.WriteLine(esko.Show());

            Console.ForegroundColor = ConsoleColor.Blue;            

            int i = 0;
            while (i < 25)
            {
                ollie.Study();
                i = i + 1;
            }
            Console.WriteLine(ollie.Show());            
            Console.ResetColor();

            Console.WriteLine();
            PrintPersons(list);
        }
        public static void PrintPersons(List<Person> l) 
        {            
            l.Add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 3500));
            l.Add(new Student("Ollie Welles", "6381 Hollywood Blvd. Los Angeles 90028"));
            foreach (Person person in l) 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(person.Show());
                Console.ResetColor();
            }
        }
    }
}
//Написати програму для пошуку однакових елементів у двох словниках.
//Вхідний словник: { 'key1': 1, 'key2': 3, 'key3': 2}, { 'key1': 1, 'key2': 2}
//Результат програми: key1: 1 is present in both x and y

using Newtonsoft.Json;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string s;
        do
        {
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //dic.Add("key1", 1);
            //dic.Add("key2", 3);
            //dic.Add("key3", 2);
            //Dictionary<string, int> dic1 = new Dictionary<string, int>();
            //dic1.Add("key1", 1);
            //dic1.Add("key2", 2);
            //dic1.Add("key3", 2);
            string q;
            string r;
            try
            {
                Console.WriteLine("Введiть перший словник");
                q = Console.ReadLine();
                Console.WriteLine("Введiть другий словник");
                r = Console.ReadLine();

                Dictionary<string, int> dic = JsonConvert.DeserializeObject<Dictionary<string, int>>(q);
                Dictionary<string, int> dic1 = JsonConvert.DeserializeObject<Dictionary<string, int>>(r);
                foreach (KeyValuePair<string, int> i in dic)
                {
                    foreach (KeyValuePair<string, int> x in dic1)
                    {
                        if (x.Key == i.Key && x.Value == i.Value)
                        {
                            Console.WriteLine(i.Value + $" is present in both {i.Key} and {x.Key}");
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Невiрний ввiд"); }
           
            //string s1 = JsonConvert.SerializeObject(dic1);


            Console.WriteLine("\nВийти так/нi");
            s = Console.ReadLine();
        } while (s != "так");
    }
}




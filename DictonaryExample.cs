using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace ServerCode
{
    class DictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("1", "Akshay");
            dic.Add("2", "Hari");
            dic.Add("3", "Raghvan");
            dic.Add("4", "Milind");
            dic.Add("5", null);
            dic.Add("6", "Mahesh");
            dic.Add("10", "Mahesh");
            dic.Add("7", "druva");
            dic.Add("8", "main");
            dic.Add("9", "main");
            Console.WriteLine();



        Start:
            Console.WriteLine("Enter which Operation do u want Perform \n  1.Delete 2.Insert ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            if (s1 == 1)
            {
                try
                {
                    Console.WriteLine("Enter Key to Delete");
                    string data = Console.ReadLine();
                    dic.Remove(data);

                }
                catch (Exception e)
                {
                    Console.WriteLine("You Entered Key is not avialble");
                }
            }
            else if (s1 == 2)
            {
                try
                {
                    Console.WriteLine("Enter key and value to Insert");
                    string k1 = Console.ReadLine();
                    string val1 = Console.ReadLine();
                    dic.Add(k1, val1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("If you want to perform the Operations Again then press (y/Y)");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if (ch1 == 'y' || ch1 == 'Y')
            {
                goto Start;
            }
            else
            {
                string json = JsonConvert.SerializeObject(dic, Formatting.Indented);
                Console.WriteLine(json);
                File.WriteAllText(@"C:\Users\Govardhan Reddy\source\repos\ExamForMe\ExamForMe\JsonDic.json", json);


                Dictionary<string, string> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                IEnumerable<String> key1 = htmlAttributes.Keys;
                foreach (string keyeys in key1)
                {
                    Console.WriteLine(keyeys + " : " + dic[keyeys]);
                }
            }
        }
    }
}

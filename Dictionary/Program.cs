using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myDict = new Dictionary<int, string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    string tmp = Console.ReadLine();
            //    myDict.Add(i, tmp);
            //}

            //Console.WriteLine("-----------------------------------");

            //foreach (var item in myDict)
            //{
            //    Console.WriteLine($"The key: {item.Key} The value is: {item.Value}");
            //}

            var users = new Dictionary<int, User>();

            var U1 = new User { Id = 100, Name = "Lars" };
            var U2 = new User { Id = 101, Name = "Joe" };
            var U3 = new User { Id = 102, Name = "Roger" };

            users.Add(U1.Id, U1);
            users.Add(U2.Id, U2);
            users.Add(U3.Id, U3);
            //int counter = 100;
            //foreach (var user in users.Keys)
            //{        
            //    Console.WriteLine(users.First(x => x.Key == counter));
            //    counter++;
            //}
            //foreach (User item in users.Values)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}
            //foreach (int key in users.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //var specify =
            //    from user in users
            //    where user.Value.Id == 101
            //    select user;

            //foreach (var i in specify)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("contains");
            Console.WriteLine("----------------");

            if (!users.ContainsKey(105))
            {
                users.Add(105, new User { Id = 105,  Name = "Sam" });
            }
            //foreach (var item in users.Values)
            //{
            //    Console.WriteLine(item);
            //}
            User ValUser;
            var found = users.TryGetValue(105, out ValUser);
            Console.WriteLine(ValUser.ToString());


            Console.WriteLine(users.Count);
            Console.WriteLine(users.Count(n => n.Value.Name == "Sam"));







        }
    }

    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return Id + "  " + Name;
        }
    }
}

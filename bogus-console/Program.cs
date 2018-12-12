using System;
using Bogus;
using System.Linq;
using System.Collections.Generic;

namespace bogus_console
{
    class Program
    {
        static void Main(string[] args)
        {
           var ans= GetSampleTableData();
           
           foreach(var item in ans)
           {
                Console.WriteLine(item.topicId);
                Console.WriteLine(item.topicName);
           }
        }

        private static List<Topic> GetSampleTableData()
        {

            var userFaker = new Faker<Topic>()
            //.RuleFor(t => t.topicId, f => f.IndexFaker)
            .RuleFor(t => t.topicId, f => f.Name.FirstName())
            .RuleFor(t => t.topicName, f => f.Internet.Avatar());
            var users = userFaker.Generate(2);
           // string full=new Bogus.DataSets.Name().FullName();
           // Console.WriteLine(""+full);
            Topic obj1=userFaker;
            //Console.WriteLine(users.DumpAsJson());

            return users;
        }
    }
}

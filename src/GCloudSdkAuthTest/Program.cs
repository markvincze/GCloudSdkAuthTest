using System;
using Google.Cloud.Datastore.V1;
using Newtonsoft.Json;

namespace GCloudSdkAuthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var db = DatastoreDb.Create("dev-test-travix-com", "travix-enosis");

                var key = db.CreateKeyFactory("ItineraryCache").CreateKey("20170911164022999-Stubbed-2016-03-22");
                var result = db.Lookup(key);

                Console.WriteLine("Entity was retrieved: {0}", JsonConvert.SerializeObject(result));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

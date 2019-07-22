using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace MongoDbConsoleApp
{
    class Program
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        [Obsolete]
        static void Main(string[] args)
        {
            do
            {
                ObjectId id = ObjectId.GenerateNewId();
                Stopwatch stopwatch = new Stopwatch();


                stopwatch.Restart();
                Console.WriteLine("");
                Console.WriteLine("====================================================");

                MongoService mongoService = new MongoService();
                FilterDefinitionBuilder<BsonDocument> filterDefinitionBuilder = new FilterDefinitionBuilder<BsonDocument>();
                filterDefinitionBuilder.Or();
                // mongoService.Collection.Indexes.DropAll();
                //mongoService.Collection.Indexes.CreateOne(Builders<BsonDocument>.IndexKeys.Ascending("Name"));
                var length = 50000;
                var models = new List<WriteModel<Symbol>>();
                for (int i = 0; i < length; i++)
                {
                    models.Add(new InsertOneModel<Symbol>(new Symbol() { ID = id, Name = "star" + i }));
                }
                mongoService.Collection.BulkWrite(models.ToArray());
                stopwatch.Stop();
                Console.WriteLine($"bulk write cost time {stopwatch.ElapsedMilliseconds}");
                Console.WriteLine("====================================================");
                stopwatch.Restart();

                var filterBuilder = Builders<Symbol>.Filter;
                List<FilterDefinition<Symbol>> jjdFilterDefinitions = new List<FilterDefinition<Symbol>>();
                List<FilterDefinition<BsonDocument>> fkdFilterDefinitions = new List<FilterDefinition<BsonDocument>>();
                var jjdfilter = filterBuilder.Empty;
                var fkdfilter = filterBuilder.Empty;
                var document = mongoService.Collection.Count(new BsonDocument("Name", new Regex("Star1", RegexOptions.IgnoreCase)));
                //var document = mongoService.Collection.Count(new BsonDocument("ID", ObjectId.Empty));
                //var match = Query.Matches("name", BsonRegularExpression.Create(new Regex("Joe")));
                // mongoService.Collection.Find(match);
                Console.WriteLine($"count {mongoService.Collection.Count(new BsonDocument())}");
                stopwatch.Restart();

                jjdFilterDefinitions.Add(filterBuilder.Regex("Name", new BsonRegularExpression("star")));
                jjdfilter = filterBuilder.And(jjdFilterDefinitions);
                var length1 = mongoService.Collection.Find(jjdfilter).Count();
                Console.WriteLine($"length {length1}");
                stopwatch.Stop();
                Console.WriteLine($"cost time {stopwatch.ElapsedMilliseconds}");
                Console.WriteLine("====================================================");
            } while (Console.ReadKey().Key != ConsoleKey.Q);



            // ForEach(mongoService);
            Console.ReadLine();
        }

        private static async System.Threading.Tasks.Task ForEach(MongoService mongoService)
        {
            await mongoService.Collection.Find(new BsonDocument()).ForEachAsync(d => Console.WriteLine(d));
        }
    }

    [BsonIgnoreExtraElements]
    public class Symbol
    {
        public string Name { get; set; }
        public ObjectId ID { get; set; }
        public string Random { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;
        public DateTime Time1 { get; set; } = DateTime.Now;
        public DateTime Time2 { get; set; } = DateTime.Now;
        public DateTime Time3 { get; set; } = DateTime.Now;
        public DateTime Time4 { get; set; } = DateTime.Now;
        public DateTime Time5 { get; set; } = DateTime.Now;
        public DateTime Time6 { get; set; } = DateTime.Now;
        public DateTime Time14 { get; set; } = DateTime.Now;
        public DateTime Time7 { get; set; } = DateTime.Now;
        public DateTime Time8 { get; set; } = DateTime.Now;
        public DateTime Time9 { get; set; } = DateTime.Now;
        public DateTime Time10 { get; set; } = DateTime.Now;
        public DateTime Time11 { get; set; } = DateTime.Now;
        public DateTime Time12 { get; set; } = DateTime.Now;
        public DateTime Time13 { get; set; } = DateTime.Now;
        public Symbol()
        {
            Random = Guid.NewGuid().ToString();
        }

    }
}

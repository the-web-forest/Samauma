using MongoDB.Driver;
using Samauma.Domain.Models;

namespace Samauma.Configuration
{
	public static class Databases
    {
        public static void Configure(WebApplicationBuilder builder)
        {
			var Database = new MongoClient(builder.Configuration["Database:ConnectionString"]).GetDatabase(builder.Configuration["Database:Name"]);
			ConfigurePartnerCollection(Database);
			builder.Services.AddSingleton(x => Database);
		}

		private static void ConfigurePartnerCollection(IMongoDatabase Database)
		{
			var partnerCollection = Database.GetCollection<Partner>(typeof(Partner).Name);
			var indexOptions = new CreateIndexOptions();
			var indexKeys = Builders<Partner>.IndexKeys
				.Ascending(x => x.CreatedAt)
				.Ascending(x => x.Name)
				.Descending(x => x.Code);
			var indexModel = new CreateIndexModel<Partner>(indexKeys, indexOptions);
			partnerCollection.Indexes.CreateOne(indexModel);
		}
	}
}


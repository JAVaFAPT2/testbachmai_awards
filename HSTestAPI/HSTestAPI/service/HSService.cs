using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestHsAPI.Models;

namespace TestHsAPI.service
{
    public class HSService
    {
        private readonly IMongoCollection<Hs> _hsCollection;
        private readonly DiscountService _discountService;

        public HSService(IMongoDatabase database, DiscountService discountService)
        {
            _hsCollection = database.GetCollection<Hs>("Hs");
            _discountService = discountService;

            // Create indexes for frequently searched fields
            var indexKeysDefinition = Builders<Hs>.IndexKeys.Combine(
                Builders<Hs>.IndexKeys.Ascending(hs => hs.FirstName),
                Builders<Hs>.IndexKeys.Ascending(hs => hs.LastName),
                Builders<Hs>.IndexKeys.Ascending(hs => hs.PhoneNumber),
                Builders<Hs>.IndexKeys.Ascending(hs => hs.NgayDangKi)
            );
            _hsCollection.Indexes.CreateOne(new CreateIndexModel<Hs>(indexKeysDefinition));
        }

        public async Task<List<Hs>> GetAllAsync()
        {
            return await _hsCollection.Find(hs => true).ToListAsync();
        }

        public async Task<Hs> GetByIdAsync(string id)
        {
            return await _hsCollection.Find(hs => hs.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Hs hs)
        {
            // Apply discount logic
            hs.Price = _discountService.ApplyDiscount(hs);

            await _hsCollection.InsertOneAsync(hs);
        }

        public async Task UpdateAsync(string id, Hs updatedHs)
        {
            await _hsCollection.ReplaceOneAsync(hs => hs.Id == id, updatedHs);
        }

        public async Task DeleteAsync(string id)
        {
            await _hsCollection.DeleteOneAsync(hs => hs.Id == id);
        }

        public async Task<List<BsonDocument>> GetAggregatedDataAsync()
        {
            var pipeline = new BsonDocument[]
            {
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", "$somondangki" },
                    { "totalPrice", new BsonDocument("$sum", "$price") },
                    { "averagePrice", new BsonDocument("$avg", "$price") }
                })
            };

            var result = await _hsCollection.Aggregate<BsonDocument>(pipeline).ToListAsync();
            return result;
        }

        public async Task<string> GetFullNameAsync(string id)
        {
            var hs = await _hsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return hs == null ? null : $"{hs.FirstName} {hs.LastName}";
        }

        public async Task<decimal> GetMaxPriceAsync()
        {
            var hs = await _hsCollection.Find(_ => true).SortByDescending(x => x.Price).FirstOrDefaultAsync();
            return hs?.Price ?? 0;
        }

        public async Task<decimal> GetMinPriceAsync()
        {
            var hs = await _hsCollection.Find(_ => true).SortBy(x => x.Price).FirstOrDefaultAsync();
            return hs?.Price ?? 0;
        }

        public async Task<List<Hs>> SearchByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _hsCollection.Find(x => x.NgayDangKi >= startDate && x.NgayDangKi <= endDate).ToListAsync();
        }

        public async Task<List<Hs>> SearchByKeywordAsync(string keyword)
        {
            var filter = Builders<Hs>.Filter.Or(
                Builders<Hs>.Filter.Regex("firstName", new BsonRegularExpression(keyword, "i")),
                Builders<Hs>.Filter.Regex("lastName", new BsonRegularExpression(keyword, "i")),
                Builders<Hs>.Filter.Regex("phoneNumber", new BsonRegularExpression(keyword, "i"))
            );
            return await _hsCollection.Find(filter).ToListAsync();
        }

        public async Task<List<Hs>> SearchByNameAsync(string name)
        {
            var filter = Builders<Hs>.Filter.Or(
                Builders<Hs>.Filter.Regex("firstName", new BsonRegularExpression(name, "i")),
                Builders<Hs>.Filter.Regex("lastName", new BsonRegularExpression(name, "i"))
            );
            return await _hsCollection.Find(filter).ToListAsync();
        }
    }
}

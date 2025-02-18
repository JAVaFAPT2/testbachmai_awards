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
        

    }
}

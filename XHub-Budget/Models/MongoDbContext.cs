using MongoDB.Driver;

namespace XHub_Budget.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://taskapp:mertmert12@cluster0.o1qpe.mongodb.net/budget-cal?retryWrites=true");
            _mongoDb = client.GetDatabase("budget-col");
        }
        public IMongoCollection<Employee> Employee
        {
            get
            {
                return _mongoDb.GetCollection<Employee>("Employee");
            }
        }
    }
}
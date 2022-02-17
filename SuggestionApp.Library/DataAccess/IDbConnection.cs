namespace SuggestionApp.Library.DataAccess;

public interface IDbConnection
{
    string DatabaseName { get; }
    string CategoryCollectionName { get; }
    string StatusCollectionName { get; }
    string UserCollectionName { get; }
    string SuggestionCollectionName { get; }

    MongoClient Client { get; }
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    IMongoCollection<UserModel> UserCollection { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
}
using MongoDB.Driver;

namespace MongoDBRepository.Repository.Context
{
    public interface IConnectionFactory
    {
        IMongoClient GetClient( );
        IMongoDatabase GetDatabase( IMongoClient p_MongoClient, string p_DatabaseName );
        IMongoDatabase GetDatabase( string p_DatabaseName );
    }
}

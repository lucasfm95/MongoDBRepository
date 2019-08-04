using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBRespository.Repository.Context
{
    public interface IConnectionFactory
    {
        IMongoClient GetClient( );
        IMongoDatabase GetDatabase( IMongoClient p_MongoClient, string p_DatabaseName );
        IMongoDatabase GetDatabase( string p_DatabaseName );
    }
}

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBRespository.Repository.Interface
{
    public interface IRepository<T>
    {
        List<T> FindAll( );
        void Insert( T p_Obj );
    }
}

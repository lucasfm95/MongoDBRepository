using MongoDB.Driver;
using MongoDBRespository.Repository.Context;
using MongoDBRespository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBRespository.Repository.Base
{
    /// <summary>
    /// Repositório genérico
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T>
    {
        private readonly IMongoCollection<T> m_Collection;

        public Repository( IConnectionFactory p_ConnectionFactory, string p_DatabaseName, string p_CollectionName )
        {
            m_Collection = p_ConnectionFactory.GetDatabase( p_DatabaseName ).GetCollection<T>( p_CollectionName );
        }

        /// <summary>
        /// Retorna todos os documentos da collection
        /// </summary>
        /// <returns>Lista de objetos</returns>
        public List<T> FindAll( )
        {
            return m_Collection.AsQueryable<T>( ).ToList( );
        }

        /// <summary>
        /// Retorna a collection
        /// </summary>
        /// <returns>Mongo collection</returns>
        protected IMongoCollection<T> GetCollection( )
        {
            return m_Collection;
        }

        /// <summary>
        /// Insere um novo objeto
        /// </summary>
        /// <param name="p_Obj">Objeto</param>
        public void Insert( T p_Obj )
        {
            m_Collection.InsertOne( p_Obj );
        }
    }
}

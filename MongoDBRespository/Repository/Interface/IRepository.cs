using System.Collections.Generic;

namespace MongoDBRepository.Repository.Interface
{
    public interface IRepository<T>
    {
        List<T> FindAll( );
        void Insert( T p_Obj );
    }
}

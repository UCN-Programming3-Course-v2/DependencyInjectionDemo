using MovieDAL.Daos;
using MovieDAL.Model;
using System;

namespace MovieDAL
{
    public static class DaoFactory
    {
        public static IDao<TEntity> Create<TEntity>()
        {
            switch (typeof(TEntity))
            {
                case var entityType when entityType == typeof(Movie):
                    return new MovieDao() as IDao<TEntity>;
                default:
                    throw new Exception("Unknown DAO");
            }
        }
    }
}

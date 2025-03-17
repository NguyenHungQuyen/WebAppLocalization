using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Models
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(IDbConnection connection) : base(connection) { }

        public IEnumerable<Category> GetCategories()
        {
            return connection.Query<Category>("SELECT * FROM Category");
        }
    }

}
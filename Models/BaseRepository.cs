using System.Data;

namespace Models
{
    public abstract class BaseRepository
    {
        protected readonly IDbConnection connection;

        protected BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}

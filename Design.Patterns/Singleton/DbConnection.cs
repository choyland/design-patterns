using System;

namespace Singleton
{
    public class DbConnection
    {
        private static DbConnection _dbConnection;
        private readonly Guid _connectionId;

        private DbConnection()
        {
            _connectionId = Guid.NewGuid();
        }

        public static DbConnection CreateConnection()
        {
            return _dbConnection ??= new DbConnection();
        }

        public Guid GetConnectionId()
        {
            return _connectionId;
        }
    }
}

namespace testapp
{
    public class DBConnection : IDBConnection
    {
        private readonly IConnector _connection;
        public DBConnection(IConnector connection)
        {
            _connection = connection;
            System.Console.WriteLine("DI class");
        }

        public void Connection()
        {
            _connection.TryConnection();
        }

        public void GetLogs()
        {
            System.Console.WriteLine("Logging started..");
        }
    }
}
namespace testapp
{
    public class DBConnection : IDBConnection
    {
        public DBConnection()
        {
            System.Console.WriteLine("Old school class");
        }

        public void Connection()
        {
            System.Console.WriteLine("Connection using credentials");
        }

        public void GetLogs()
        {
            System.Console.WriteLine("Logging started..");
        }
    }
}
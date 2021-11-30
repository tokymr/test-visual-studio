using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IConnector connector = new CasualConnector(){User="user", Pass="password123", Port=1234, Host="localhost"};
            IDBConnection conn = new DBConnection(connector);
            conn.Connection();

        }
    }
}

using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IDBConnection connector = new DBConnection();
            connector.Connection();

        }
    }
}

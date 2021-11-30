namespace testapp
{
    class CasualConnector : IConnector
    {
        public string User{get;set;}
        public string Pass{get;set;}
        public string Host{get;set;}
        public int Port{get;set;}

        public void TryConnection()
        {
            System.Console.WriteLine("Connection using CasualConnector class");
        }
    }
}
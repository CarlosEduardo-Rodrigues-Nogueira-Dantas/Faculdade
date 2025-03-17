namespace Faculdade.Options
{
    public class ConnectionStringOptions
    {
        public string MyConnection { get; set; }

        public ConnectionStringOptions(string myConnection)
        {
            MyConnection = myConnection;
        }
    }
}

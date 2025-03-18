namespace Faculdade.Options
{
    // Classe que representa as opções de conexão com o banco de dados (string de conexão)  
    public class ConnectionStringOptions
    {
        // Propriedade que armazena a string de conexão com o banco de dados 
        public string MyConnection { get; set; }

        // Construtor que recebe a string de conexão com o banco de dados
        public ConnectionStringOptions(string myConnection)
        {
            MyConnection = myConnection;
        }
    }
}

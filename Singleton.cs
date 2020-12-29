namespace PatternsExam
{
    public class Singleton
    {
        public string name;
        public string login;
        public static string connectionString;
        public static Singleton oracleConnection;
        private Singleton()
        {

        }
        public static Singleton CreateConnection()
        {
            if (oracleConnection == null)
            {
                oracleConnection = new Singleton();
            }

            return oracleConnection;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetLogin(string newLogin)
        {
            login = newLogin;
        }

        public string GetLogin()
        {
            return login;
        }
    }
}
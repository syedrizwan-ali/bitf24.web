namespace FCIT.BITF24A.Web.DiPractice
{
    public class PostgreSqlConnection : IClassDbConnection
    {
        public string Connect()
        {
            return "PostgreSql Connected";
        }
    }
}

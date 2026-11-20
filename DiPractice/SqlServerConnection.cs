namespace FCIT.BITF24A.Web.DiPractice
{
    public class SqlServerConnection : IClassDbConnection
    {
        public string Connect()
        {
            return "SQL Server Connected";
        }
    }
}

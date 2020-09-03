namespace SecondCaliburnApp.Commons
{
    public class StaticInfos
    {
        public static string CONNSTR = "Data Source=127.0.0.0; Initial Catalog = MvvB; Initial Catalog=MvvmDB; Persist Security Info=True; User ID=root;Password=epfls+358471";
    }

    public static class InnerQry
    {
        public static string GET_People_QRY = "SELECT FirstName, LastName " +
                                                    " FROM dbo.PeopleTBL " +
                                                    " ORDER BY Ids ACS ";
    }
}

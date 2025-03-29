using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Server=DESKTOP-GE9UJQI;Database=DbYazOkulu;Trusted_Connection=True;");
    }
}

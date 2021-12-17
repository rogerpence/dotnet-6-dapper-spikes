using Dapper;
using Microsoft.Data.SqlClient;

public record Artist
{
    public string Name { get; init; }
    public bool PrefixWithThe { get; init; }
}

public class Spikes
{
    const string CONNECTION_STRING = @"Data Source=.;Initial Catalog=Sugarfoot;Integrated Security=True;TrustServerCertificate=True";

    public void AnonymousResult()
    {
        string sql = "SELECT * FROM Artist";
        
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            IEnumerable<dynamic> artists = connection.Query<dynamic>(sql);

            foreach (var rows in artists)
            {
                var fields = rows as IDictionary<string, object>;
                string? name = fields["Name"].ToString();
                bool? prefixWithThe = (bool)fields["PrefixWithThe"];
                Console.WriteLine($"Name: {name} prefixWithThe: {prefixWithThe}");
            }
        }
    }

    public void StronglyTypedResult()
    {
        string sql = "SELECT * FROM Artist";

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            List<Artist> artists = connection.Query<Artist>(sql).ToList();

            foreach (var a in artists)
            {
                Console.WriteLine($"Name: {a.Name} prefixWithThe: {a.PrefixWithThe}");
            }
        }
    }

    public IEnumerable<Artist> StronglyTypedResultWithWhere()
    {
        string sql = "SELECT * FROM Artist where PrefixWithThe = @PrefixWithThe";

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            //List<artist> artists = connection.Query<artist>(sql, 
            //                                                new {PrefixWithThe = true}).ToList();

            IEnumerable<Artist> artists = connection.Query<Artist>(sql,
                                                            new { PrefixWithThe = true }).ToList();

            return artists;
            //foreach (var a in artists)
            //{
            //    Console.WriteLine($"Name: {a.Name} prefixWithThe: {a.PrefixWithThe}");
            //}
        }
    }


}


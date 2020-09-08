using System;
using MySql.Data.MySqlClient;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            // db connection details 
            string server = "localhost";
            string user = "root";
            string password = "root";
            string dbname = "moviehouse";

            using var conn = new MySqlConnection(@"server=" + server +
                                                        ";userid=" + user + "" +
                                                        ";password=" + password + "" +
                                                        ";database=" + dbname);
            conn.Open();

            //string sql = "SELECT DISTINCT movies.genre, COUNT(*) FROM movies, tickets WHERE movies.movieid=tickets.movieid AND movies.genre IS NOT NULL GROUP BY movies.genre;";
            string sql = ""; /* place sql here */ 

            using var command = new MySqlCommand(sql, conn);

            using MySqlDataReader reader = command.ExecuteReader();

            Console.WriteLine($"{"Genre", -30} {"Tickets", 5}");
            Console.WriteLine("________________________________________________");
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetString(0), -30} {reader.GetInt32(1), 5}");
            }
        }
    }
}

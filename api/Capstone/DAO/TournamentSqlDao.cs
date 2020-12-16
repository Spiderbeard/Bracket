using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class TournamentSqlDao : ITournamentDAO
    {
        private string connectionString;

        public TournamentSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Tournament AddTournament(Tournament tournament)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "Insert into tournament(name, numberofparticipants, currentround, organizer_id) " +
                        "VALUES(@name, @numberofparticipants, @currentround, @organizer_id);select scope_identity();";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@name", tournament.name);
                    cmd.Parameters.AddWithValue("@numberofparticipants", tournament.numberofparticipants);
                    cmd.Parameters.AddWithValue("@currentround", tournament.currentround);
                    cmd.Parameters.AddWithValue("@organizer_id", tournament.organizer_id);

                    tournament.tournament_id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return tournament;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}

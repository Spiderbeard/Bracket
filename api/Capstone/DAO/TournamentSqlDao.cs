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

        public MatchSqlDAO matchDAO = new MatchSqlDAO();

        public ParticipantsSqlDAO participantsDAO = new ParticipantsSqlDAO();

        public RoundsSqlDAO roundsDAO = new RoundsSqlDAO();

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
                    cmd.Parameters.AddWithValue("@name", tournament.Name);
                    cmd.Parameters.AddWithValue("@numberofparticipants", tournament.NumberOfParticipants);
                    cmd.Parameters.AddWithValue("@currentround", tournament.CurrentRound);
                    cmd.Parameters.AddWithValue("@organizer_id", tournament.OrganizerId);

                    tournament.TournamentId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return tournament;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Tournament> GetAllTournaments()
        {
            List<Tournament> returnTournaments = new List<Tournament>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "SELECT matchnumber, isActive, scoreteam1, scoreteam2, team1winner, team2winner, round_id, match_id, team1, team2 FROM match";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Tournament t = GetTournamentFromReader(reader);
                            returnTournaments.Add(t);
                            
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return returnTournaments;
        }

        private Tournament GetTournamentFromReader(SqlDataReader reader)
        {
            Tournament t = new Tournament()
            {
                TournamentId = Convert.ToInt32(reader["tournament_id"]),
                Name = Convert.ToString(reader["name"]),
                NumberOfParticipants = Convert.ToInt32(reader["numberofparticipants"]),
                CurrentRound = Convert.ToInt32(reader["currentround"]),
                OrganizerId = Convert.ToInt32(reader["organizer_id"]),
            };

            return t;
        }
    }
}

    






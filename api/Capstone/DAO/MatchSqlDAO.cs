using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAO
{
    public class MatchSqlDAO : IMatchDAO
    {
        private string connectionString { get; }

        public MatchSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public MatchSqlDAO()
        {
        }

        public Match AddMatch(Match match)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "Insert into match(matchnumber, round_id, team1, team2) " +
                        "VALUES(@matchnumber, @round_id, @team1, @team2);select scope_identity();";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@matchnumber", match.MatchNumber);
                    cmd.Parameters.AddWithValue("@round_id", match.RoundId);
                    cmd.Parameters.AddWithValue("@team1", match.Team1);
                    cmd.Parameters.AddWithValue("@team2", match.Team2);
                    match.MatchId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return match;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Match> GetAllMatches()
        {
            List<Match> returnMatches = new List<Match>();

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
                        while(reader.Read())
                        {
                            Match m = GetMatchFromReader(reader);
                            returnMatches.Add(m);
                        }
                    }

                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return returnMatches;
        }

        public Match GetMatch(int matchId)
        {
            Match returnMatch = null;

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatment = "SELECT matchnumber, isActive, scoreteam1, scoreteam2, team1winner, team2winner, round_id, team1, team2 FROM match WHERE match_id = @match_id";
                    SqlCommand cmd = new SqlCommand(sqlStatment, conn);
                    cmd.Parameters.AddWithValue("@match_id", matchId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.HasRows && reader.Read())
                    {
                        returnMatch = GetMatchFromReader(reader);
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return returnMatch;
        }

        public List<Match> GetMatchByRoundId(List<int> roundIds)
        {
            
            List<Match> returnMatches = new List<Match>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = $"SELECT * FROM match WHERE round_id in ({roundIds})";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Match m = GetMatchFromReader(reader);
                            returnMatches.Add(m);

                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return returnMatches;
        }

        public bool UpdateScoreTeamOne(Match updated)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatment = "UPDATE match SET scoreteam1 = @scoreteam1 WHERE match_id = @match_id";
                    SqlCommand cmd = new SqlCommand(sqlStatment, conn);
                    cmd.Parameters.AddWithValue("@scoreteam1", updated.ScoreTeam1);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateScoreTeamTwo(Match updated)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatment = "UPDATE match SET scoreteam2 = @scoreteam2 WHERE match_id = @match_id";
                    SqlCommand cmd = new SqlCommand(sqlStatment, conn);
                    cmd.Parameters.AddWithValue("@scoreteam2", updated.ScoreTeam2);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Match GetMatchFromReader(SqlDataReader reader)
        {
            Match m = new Match()
            {
                MatchNumber = Convert.ToInt32(reader["matchnumber"]),
                IsActive = Convert.ToBoolean(reader["isActive"]),
                ScoreTeam1 = Convert.ToInt32(reader["scoreteam1"]),
                ScoreTeam2 = Convert.ToInt32(reader["scoreteam2"]),
                Team1Winner = Convert.ToBoolean(reader["team1winner"]),
                Team2Winner = Convert.ToBoolean(reader["team2winner"]),
                RoundId = Convert.ToInt32(reader["round_id"]),
                MatchId = Convert.ToInt32(reader["match_id"]),
                Team1 = Convert.ToInt32(reader["team1"]),
                Team2 = Convert.ToInt32(reader["team2"]),
            };

            return m;
        }

        
    }
}

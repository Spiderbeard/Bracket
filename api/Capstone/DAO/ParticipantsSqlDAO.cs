using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class ParticipantsSqlDAO : IParticipantsDAO
    {
        private string connectionString { get; }

        public ParticipantsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public ParticipantsSqlDAO()
        {
        }

        public Participants AddParticipants(Participants participant)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "Insert into participants(name) " +
                        "VALUES(@name);select scope_identity();";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@name", participant.Name);
                    participant.ParticipantId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return participant;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Participants> GetAllParticipants()
        {
            List<Participants> returnParticipants = new List<Participants>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "SELECT participant_id, name, isActive FROM participants";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Participants p = GetParticipantFromReader(reader);
                            returnParticipants.Add(p);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return returnParticipants;
        }

        public Participants GetParticipants(int participantId)
        {
            Participants returnParticipant = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatment = "SELECT participant_id, name, isActive FROM participants WHERE participant_id = @participant_id";
                    SqlCommand cmd = new SqlCommand(sqlStatment, conn);
                    cmd.Parameters.AddWithValue("@participant_id", participantId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        returnParticipant = GetParticipantFromReader(reader);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return returnParticipant;
        }

        public List<Participants> GetParticipantsByMatchIds(List<int> MatchIDs)
        {
            List<Participants>  output = new List<Participants>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string SqlStatement = $" select matchnumber, isActive, scoreteam1, scoreteam2, team1winner, team2winner, round_id, match_id, team1, team2, " +
                        $"participant_id as participant1_Id, name as participant1_name, isActive as particpant1_isActive, participant_id as participant2_Id, name as participant2_name, isActive as participant2_isActive" +
                        $"from match p join paticipants m1 on p.team1 = m1.participant_id join participants m2 on p.team2= m2.participant_id where match_id in ({MatchIDs}) ";
                    SqlCommand cmd = new SqlCommand(SqlStatement,  conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Participants p =  GetParticipantFromReader(reader);
                            output.Add(p);
                        }
                    }


                }
            }
            catch (Exception e)
            {

                throw e;
            }


            return output;
        }

        public Match GetMatchAndSomeParticipantsFromReader(SqlDataReader reader)
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
                Participant1_Id = Convert.ToInt32(reader["participant1_id"]),
                Participant1_name = Convert.ToString(reader["participant1_name"]),
                Participant1_isActive = Convert.ToBoolean(reader["participant2_id"]),
                Participant2_Id = Convert.ToInt32(reader["participant2_id"]),
                Participant2_name = Convert.ToString(reader["participant2_name"]),
                Participant2_isActive = Convert.ToBoolean(reader["participant2_isActive"]),

            };
           

            return m;
        }

        public Participants GetParticipantFromReader(SqlDataReader reader)
        {
            Participants p = new Participants()
            {
                ParticipantId = Convert.ToInt32(reader["participant_id"]),
                Name = Convert.ToString(reader["name"]),
                IsActive = Convert.ToBoolean(reader["isActive"]),
                
            };

            return p;
        }

      
    }
}

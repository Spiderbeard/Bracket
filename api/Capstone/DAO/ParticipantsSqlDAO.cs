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

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
        private static string connectionString;

        public TournamentSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public MatchSqlDAO matchDAO = new MatchSqlDAO(connectionString);

        public ParticipantsSqlDAO participantsDAO = new ParticipantsSqlDAO(connectionString);

        public RoundsSqlDAO roundsDAO = new RoundsSqlDAO(connectionString);

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
                    string sqlStatement = "SELECT * FROM tournament";
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

        public List<Tournament> GetTournamentByOrganizerId(int organizerId)
        {
            List<Tournament> returnTournaments = new List<Tournament>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlStatement = "SELECT tournament_id, name, numberofparticipants, currentround, organizer_id FROM tournament WHERE organizer_id = @organizer_id";
                    SqlCommand tourneyCmd = new SqlCommand(sqlStatement, conn);
                    tourneyCmd.Parameters.AddWithValue("@organizer_id", organizerId);
                    SqlDataReader reader = tourneyCmd.ExecuteReader();

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

        public List<Tournament> AllYourTournamentAreBelongToMe(int OrganizerId)
        {
            List<Tournament> output = new List<Tournament>();



            List<Tournament> tournamentList = GetTournamentByOrganizerId(OrganizerId);

            List<int> tournamentIds = new List<int>();

            List<int> roundIds = new List<int>();

            List<int> matchIds = new List<int>();

            foreach (Tournament tourney in tournamentList)
            {
                output.Add(tourney);

                tournamentIds.Add(tourney.TournamentId);
            }

            List<Rounds> roundList = roundsDAO.GetRoundsByTournamentID(tournamentIds,connectionString);

            foreach (Tournament tourney in output)
            {
                foreach (Rounds round in roundList)
                {
                   
                    if (round.TournamentId == tourney.TournamentId)
                    {
                        roundIds.Add(round.RoundId);
                        tourney.Rounds.Add(round);
                    }
                }
            }

            List<Match> matchList = matchDAO.GetMatchByRoundId(roundIds,connectionString);

            foreach(Match match in matchList)
            {
                matchIds.Add(match.MatchId);
            }

            List<Match> ParticipantList = participantsDAO.GetParticipantsByMatchIds(matchIds,connectionString);
           
            foreach  (Tournament tourney in output)
            {
               for( int i =0 ; i<tourney.Rounds.Count ;i++)
                {
                    foreach(Match match in ParticipantList)
                    {
                       

                        if( match.RoundId == tourney.Rounds[i].RoundId)
                        {
                            tourney.Rounds[i].Matches.Add(match);
                        }
                    }

                }
            }
            return output;
        }

    }//ENDOFLINE
}







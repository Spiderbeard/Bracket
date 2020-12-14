using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;

namespace Capstone.Tests
{
    [TestClass]
    public class CapstoneTestsInitializer
    {
        private TransactionScope transaction  { get; set;}
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=final_capstone; Integrated Security = True";

        private int user_id { get; set; }
        private int tournament_id { get; set; }
        private int round_id { get; set; }
        private int match_id { get; set; }


        [TestInitialize]
        public void Initialize()
        {
            transaction = new TransactionScope();

            string getUserID = "select user_id from users where username = 'Tester'; ";
            string tournamentInsertStatement = $"insert into tournament  values('Test Tourney',16,1,{user_id}); select scope_identity(); select scope_identity();";
            string roundInsertStatement = $" insert into rounds values"


            using ( SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(getUserID, conn);
                SqlCommand tournamentInsert = new SqlCommand(tournamentInsertStatement, conn);






                user_id = Convert.ToInt32(cmd.ExecuteScalar());




                    




            }




            






        }
        [TestCleanup]
        public void GarbageMan()
        {
            transaction.Dispose();
        }
    }
}

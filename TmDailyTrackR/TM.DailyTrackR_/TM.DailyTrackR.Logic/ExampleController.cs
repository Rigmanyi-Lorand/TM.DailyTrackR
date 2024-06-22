namespace TM.DailyTrackR.Logic
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows;
    using System.Diagnostics;

    public sealed class ExampleController
    {
        string connectionString = @"Server=.\TM_DAILY_TRACKR;Database=TRACKR_DATA;Integrated Security=true;";

        public int GetDataExample()
        {
            string procedureName = "tm.GetAllProjectTypes";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        Dictionary<int, string> result = new Dictionary<int, string>();
                        //List<object> projectIds = new List<object>();

                        while (reader.Read())
                        {
                            // projectIds.Add(reader["project_type_id"]);
                            result.Add((int)reader["project_type_id"], (string)reader["project_type_description"]);

                        }
                        foreach (var item in result)
                        {
                            Debug.WriteLine(item.Key + " " + item.Value);
                        }
                    };
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                return 0;
            }
        }

        //Homework Insert using stored procedure

        public int InsertProjectType(string description)
        {
            string procedureName = "tm.InsertProjectType";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProjectTypeDescription", description);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                return 0;
            }
        }
    }
}

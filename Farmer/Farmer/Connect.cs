using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Farmer
{
    public class Connect
    {
        private string connectionString = @"Server=KHOAPC;Database=Animal;Trusted_Connection=True;";

        public void UpdateAnimalQuantity(int id, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Cattle SET Quantity = @Quantity WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllAnimals()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Cattle";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetAnimalDetails()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Type, Quantity, Sound FROM Cattle";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void AddOffSpring()
        {
            Random random = new Random();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string[] animalType = { "Bo", "Cuu", "De" };
                foreach (var type in animalType)
                {
                    int maxChild = type == "Bo" ? 3 : (type == "Cuu" ? 4 : 5);
                    int newOffspring = random.Next(1, maxChild + 1);

                    string query = "UPDATE Cattle SET Quantity = Quantity + @Offspring WHERE Type = @Type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Offspring", newOffspring);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AddMilk()
        {
            Random random = new Random();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string[] animalTypes = { "Bo", "Cuu", "De" };

                foreach (var type in animalTypes)
                {
                    int maxMilk = type == "Bo" ? 20 : (type == "Cuu" ? 5 : 10);
                    // Lấy tất cả các gia súc của loại hiện tại
                    string selectQuery = "SELECT Id FROM Cattle WHERE Type = @Type";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@Type", type);
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            List<int> ids = new List<int>();

                            // Collect all IDs from the reader
                            while (reader.Read())
                            {
                                ids.Add(reader.GetInt32(0));
                            }

                            reader.Close(); // Close the reader before running the next command

                            // Update milk for each ID
                            foreach (int id in ids)
                            {
                                int milkAmount = random.Next(0, maxMilk + 1);

                                string updateQuery = "UPDATE Cattle SET Milk = @Milk WHERE Id = @Id";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@Id", id);
                                    updateCmd.Parameters.AddWithValue("@Milk", milkAmount);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        public DataTable GetStatistics()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Type, SUM(Quantity) AS TotalQuantity, SUM(Milk) AS TotalMilk FROM Cattle GROUP BY Type";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

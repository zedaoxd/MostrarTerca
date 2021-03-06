using MostrarTerca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarTerca.Persistence
{
    public class DataBaseConnection
    {
        public static Vehicle GetVehicle(int id)
        {
            try
            {
                var sqlQuery = $"SELECT * FROM tb_Vehicles WHERE Id={id}";

                using (SqlConnection conn = new SqlConnection(Conn.StrConn))
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                var vehicle = new Vehicle
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    Year = Convert.ToInt32(reader["Year"]),
                                    Manufacturing = Convert.ToInt32(reader["Manufacturing"]),
                                    Color = reader["Color"].ToString(),
                                    Price = Convert.ToInt32(reader["Price"]),
                                    Fuel = FormInclude.OptionsGas[Convert.ToInt32(reader["Fuel"]) - 1],
                                    Automatic = Convert.ToBoolean(reader["Automatic"])
                                };

                                return vehicle;
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new Vehicle();
        }


        public static void ReloadDataTable(ref DataGridView dataGrid)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrConn))
                {
                    cn.Open();
                    LoadDataToDataGrid(cn, "SELECT * FROM tb_Vehicles", ref dataGrid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SearchBy(string option, string search, ref DataGridView data)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrConn))
            {

                cn.Open();
                var sqlQuery = "SELECT * FROM tb_Vehicles WHERE ";
                switch (option)
                {
                    case "Name":
                        sqlQuery += $"Name LIKE '%{search}%' ORDER BY Name";
                        break;
                    case "Model":
                        sqlQuery += $"Model LIKE '%{search}%' ORDER BY Name";
                        break;
                    case "Year":
                        sqlQuery += $"Year >= {search} ORDER BY Year";
                        break;
                    case "Manufacturing":
                        sqlQuery += $"Manufacturing >= {search} ORDER BY Manufacturing";
                        break;
                    case "Color":
                        sqlQuery += $"Color LIKE '%{search}%' ORDER BY Color";
                        break;
                    case "Price":
                        sqlQuery += $"Price >= {search} ORDER BY Price";
                        break;
                }
                LoadDataToDataGrid(cn, sqlQuery, ref data);
                cn.Close();
            }
        }

        public static void DeleteVehicle(int id)
        {
            try
            {
                var sqlQuery = $"DELETE FROM tb_Vehicles WHERE id={id}";
                using (SqlConnection cn = new SqlConnection(Conn.StrConn))
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static bool SaveVehicle(int id, string Name, string Model, string Year, string Manufacturing, string Color, string Fuel, string Automatic, string Price)
        {
            try
            {
                var sqlQuery = "";
                if (id <= 0)
                {
                    sqlQuery = "INSERT INTO tb_Vehicles (Name, Model, Year, Manufacturing, Color, Fuel, Automatic, Price)" +
                        $"VALUES ('{Name}', '{Model}', {Year}, {Manufacturing}, '{Color}', {Fuel.Substring(0, 1)}, " +
                        $"{(Automatic.Substring(0, 1).ToUpper() == "Y" ? 1 : 0)}, {Price})";
                }
                else
                {
                    sqlQuery = $"UPDATE tb_Vehicles SET Name='{Name}', Model='{Model}', Year={Year}, Manufacturing={Manufacturing}," +
                        $" Color='{Color}', Fuel={Fuel.Substring(0, 1)}, Automatic={(Automatic.Substring(0, 1).ToUpper() == "Y" ? 1 : 0)}, " +
                        $"Price={Price} WHERE Id={id}";
                }

                using (SqlConnection cn = new SqlConnection(Conn.StrConn))
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static void LoadDataToDataGrid(SqlConnection cn, string sqlQuery, ref DataGridView data)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, cn))
            using (DataTable dt = new DataTable())
            {
                adapter.Fill(dt);
                data.DataSource = dt;
            }
        }
    }
}


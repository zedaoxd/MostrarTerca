﻿using System;
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

        public static void SearchByBrand(string search, ref DataGridView data)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrConn))
            {
                cn.Open();
                var sqlQuery = $"SELECT * FROM tb_Vehicles WHERE Name LIKE '%{search}%' ORDER BY Year";
                LoadDataToDataGrid(cn, sqlQuery, ref data);
                cn.Close();
            }
        }

        public static bool SaveVehicle(string Name, string Model, string Year, string Manufacturing, string Color, string Fuel, string Automatic, string Price)
        {
            try
            {
                var sqlQuery = "INSERT INTO tb_Vehicles (Name, Model, Year, Manufacturing, Color, Fuel, Automatic, Price)" +
                        $"VALUES ('{Name}', '{Model}', {Year}, {Manufacturing}, '{Color}', {Fuel.Substring(0, 1)}, " +
                        $"{(Automatic.Substring(0, 1).ToUpper() == "Y" ? 1 : 0)}, {Price})";

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

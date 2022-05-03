using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Climaneitor
{
    class BaseDatos
    {
        private static SqlConnection conn;
        private const string conn_string = "Data source=DESKTOP-27IKLOP\\SQLEXPRESS; initial catalog=Climaneitor; trusted_connection=yes";

        public BaseDatos()
        {
            try
            {
                BaseDatos.conn = new SqlConnection(BaseDatos.conn_string);
                BaseDatos.conn.Open();
                BaseDatos.conn.Close();
                MessageBox.Show("Se ha realizado bien la operacion");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"Error");
            }
        }
        public static void modPesos(int mes,double pt, double ph, double pp, double pu)
        {
            conn = new SqlConnection(BaseDatos.conn_string);
            try
            {
                using (SqlCommand cmd = new SqlCommand("modPesos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.Add(new SqlParameter("@pMes", mes));
                    cmd.Parameters.Add(new SqlParameter("@pesT", pt));
                    cmd.Parameters.Add(new SqlParameter("@pesH", ph));
                    cmd.Parameters.Add(new SqlParameter("@pesP", pp));
                    cmd.Parameters.Add(new SqlParameter("@pesU", pu));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public static double[] getPesos(int mes) 
        {
            double[] pesos = new double[4];
            conn = new SqlConnection(BaseDatos.conn_string);
            using (SqlCommand cmd = new SqlCommand("select pesoTemp,pesoHum,pesoPres,pesoUmbral from Climaneitor.dbo.Pesos where id_peso = " + mes + ";", conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {   
                        pesos[0] = dr.GetDouble(dr.GetOrdinal("pesoTemp"));
                        pesos[1] = dr.GetDouble(dr.GetOrdinal("pesoHum"));
                        pesos[2] = dr.GetDouble(dr.GetOrdinal("pesoPres"));
                        pesos[3] = dr.GetDouble(dr.GetOrdinal("pesoUmbral"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los pesos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return pesos;
        }

        public static List<double[]> getPronosticos(int mes)
        {
            List<double[]> datos = new List<double[]>();
            conn = new SqlConnection(BaseDatos.conn_string);
            using (SqlCommand cmd = new SqlCommand("select * from Climaneitor.dbo.Pronosticos where mes = " + mes + ";", conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        datos.Add(new double[] {
                            Convert.ToDouble((bool)dr["llovio"]),                            
                            dr.GetDouble(dr.GetOrdinal("temperaturaMax")),
                            dr.GetDouble(dr.GetOrdinal("temperaturaMin")),
                            dr.GetDouble(dr.GetOrdinal("humedadMax")),
                            dr.GetDouble(dr.GetOrdinal("humedadMin")),
                            dr.GetDouble(dr.GetOrdinal("presionMax")),
                            dr.GetDouble(dr.GetOrdinal("presionMin"))
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return datos;

        }

        public static void addPronostico(string mes, double humedadMax, double humedadMin, double presionMax, double presionMin,double tempMax,double tempMin, bool llovio)
        {
            conn = new SqlConnection(BaseDatos.conn_string);
            try
            {
                using (SqlCommand cmd = new SqlCommand("addPronostico", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.Add(new SqlParameter("@mes", mes));
                    cmd.Parameters.Add(new SqlParameter("@temperaturaMax", tempMax));
                    cmd.Parameters.Add(new SqlParameter("@temperaturaMin", tempMin));
                    cmd.Parameters.Add(new SqlParameter("@humedadMax", humedadMax));
                    cmd.Parameters.Add(new SqlParameter("@humedadMin", humedadMin));
                    cmd.Parameters.Add(new SqlParameter("@presionMax", presionMax));
                    cmd.Parameters.Add(new SqlParameter("@presionMin", presionMin));
                    cmd.Parameters.Add(new SqlParameter("@llovio", llovio));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Datos guardados con exito", "Bieen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
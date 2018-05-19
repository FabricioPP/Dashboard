using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using _1Dashboard.Properties;

namespace _1Dashboard
{
    //Classe para conexão com o banco de dados
    public class DbConnection
    {
        
        //C:\\Users\\Fabricio\\Google Drive\\BANCO DASHBOARD\\Projeto_Final\\Banco\\DASHBOARD.FDB;
        //ConnectionString
        AppSetting setting = new AppSetting();
        private string strConn;
        FbConnection conn;

        //metodo para conectar com o banco de dados
        public DbConnection()
        {
            this.strConn = setting.getConnectionString("cn");
        }

        public DbConnection(string connectionString)
        {
            this.strConn = connectionString;
        }

        public void ConectarBanco()
        {           
            try {

            conn = new FbConnection(strConn);
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void testeConectarBanco(string connString)
        {
            strConn = connString;
            try
            {
                conn = new FbConnection(strConn);
                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool selectIdDispositivo(int id)
        {
            try
            {
                conn.Open();
                FbCommand cmd = new FbCommand("select * from t025dispositivos where t025id =" + id, conn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool selectIdDispositivoSemAbrirConexao(int id)
        {
            try
            {
                
                FbCommand cmd = new FbCommand("select * from t025dispositivos where t025id =" + id, conn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //metodo para dar select na frase do letreiro
        public string Select()
        {
            try
            {
                conn.Open();
                FbCommand cmd = new FbCommand("Select LETREIRO from RETORNAPROGRAMACAO(@id)", conn);
                int id = int.Parse(Settings.Default["IdDispositivo"].ToString());
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd != null)
                {
                    string texto = cmd.ExecuteScalar().ToString();
                    return texto;
                }
                else {
                    Settings.Default["IdDispositivo"] = 0;
                    Settings.Default.Save();
                    return null;
                } 
            }
            catch (Exception ex) {               
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
        }

        //metodo para dar select nas imagems
        public byte[] SelectImg()
        {
            try
            {

                conn.Open();
                FbCommand CMD = new FbCommand("Select IMAGEM from RETORNAPROGRAMACAO(@id)", conn);
                int id = int.Parse(Settings.Default["IdDispositivo"].ToString());
                CMD.Parameters.AddWithValue("@id", id);
                FbDataReader reader = CMD.ExecuteReader();

                if (reader.Read())
                {
                    byte[] image = (byte[])reader["IMAGEM"];
                    return image;

                }
                else
                {
                    Settings.Default["IdDispositivo"] = 0;
                    Settings.Default.Save();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


        }

        public bool IsConnectionn
        {
            get
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        public void dbClose()
        {
            conn.Close();
        }
    }
}

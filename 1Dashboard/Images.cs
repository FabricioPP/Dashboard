using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Dashboard
{
    //Classe so para inserir imagem no banco de dados para teste
    class Images
    {

        private string strConn = "DataSource=localhost; Database=C://Users//Fabricio//Downloads//DASHBOARD.FDB; username= SYSDBA; password = masterkey";
        FbConnection conn;


        public object MemoryStreams { get; private set; }
        public object SqlReader { get; private set; }

        public void ConectarBanco()
        {
            conn = new FbConnection(strConn);

        }

        public void Save(byte[] content)
        {
            byte[] content1 = content;
            try
            {
                FbCommand CMD = new FbCommand("INSERT INTO imageteste(image) VALUES (@IMG)", conn);




                CMD.Parameters.Add("@IMG", FbDbType.Binary).Value = content1;//salva a imagem 

                CMD.Connection.Open();
                CMD.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}

using _1Dashboard.Properties;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Dashboard
{
    public partial class Form2 : Form
    {

        DbConnection dbConnection;
        public Form2()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            string connectionString = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", cboServer.Text, txtDatabase.Text, txtUser.Text,
                                            txtPassword.Text);
            dbConnection = new DbConnection(connectionString);
            dbConnection.ConectarBanco();
            try
            {
                if (dbConnection.IsConnectionn)
                {
                    setting.saveConnectionString("cn", connectionString);
                    bool idResult = dbConnection.selectIdDispositivoSemAbrirConexao(int.Parse(cmbIdDisp.Text));
                    if (idResult == true)
                    {
                        Settings.Default["IdDispositivo"] = int.Parse(cmbIdDisp.Text);
                        int id = int.Parse(Settings.Default["IdDispositivo"].ToString());
                        if (id != 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            Settings.Default.Save();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esse dispositivo não existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Settings.Default["IdDispositivo"].ToString());
            if (id != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            cmbIdDisp.Text = "1";
            cboServer.Items.Add(".");
            cboServer.Items.Add("localhost");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Text = "localhost";
            txtDatabase.Text = "Database";
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", cboServer.Text, txtDatabase.Text, txtUser.Text,
                                                                        txtPassword.Text);
            dbConnection = new DbConnection(connectionString);
            dbConnection.ConectarBanco();
            try
            {
                if (dbConnection.IsConnectionn)
                {
                    MessageBox.Show("Teste de conexão feito com sucesso.", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                dbConnection.dbClose();
            }

        }

        private void btnBuscarDatabase_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDatabase.Text = openFileDialog1.FileName;
            }
        }
    }
}

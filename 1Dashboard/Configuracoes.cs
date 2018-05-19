using _1Dashboard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Dashboard
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {
            cmbIdDisp.Text = Settings.Default["IdDispositivo"].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK) {             
                Settings.Default.CorLetreiro = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.MinSize = 40;
            fontDialog1.MaxSize = 60;            
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.FonteLetreiro = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.ConectarBanco();
            bool idResult = dbConnection.selectIdDispositivo(int.Parse(cmbIdDisp.Text));
            if(idResult == true)
            {
                var result = MessageBox.Show("Para as alterações terem efeito é preciso reiniciar o programa. Deseja reiniciar o Programa?",
                                                    "Deseja Reiniciar o programa?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Settings.Default["IdDispositivo"] = int.Parse(cmbIdDisp.Text);
                    Settings.Default.Save();
                    Application.Restart();
                }
                else if(result == DialogResult.No)
                {
                    Settings.Default["IdDispositivo"] = int.Parse(cmbIdDisp.Text);
                    Settings.Default.Save();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Id do dispositivo não existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
                
            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que desejar resetar as configurações do software?",
                    "Deseja resetar as configurações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Settings.Default["IdDispositivo"] = 0;
                Settings.Default.FonteLetreiro = new Font("Times New Roman", 60F, System.Drawing.FontStyle.Regular);
                Settings.Default.CorLetreiro = Color.Lime;
                Settings.Default.Save();
                Application.Restart();
            }
        }
    }
}

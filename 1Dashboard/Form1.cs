using _1Dashboard.Properties;
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
    public partial class Form1 : Form
    {
        FuncoesForm func1 = new FuncoesForm();
        Images imgs = new Images();
        AppSetting setting = new AppSetting();
        DbConnection db;
        private Timer Timer { get; set; }
        private Timer Timer1 { get; set; }


        public Form1()
        {

            InitializeComponent();
            func1.fullScreen(this);
            menuStrip1.Visible = false;
            db = new DbConnection();
            db.ConectarBanco();
            //Start o DashBoard com as informãções já contida no banco de Dados
              try
              {
                  
                  byte[] grafico = db.SelectImg();
                  MemoryStream ms = new MemoryStream(grafico);
                  Image ima = Image.FromStream(ms);
                  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                  pictureBox1.Image = ima;
                  pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                  pictureBox2.Image = ima;


                  label2.Text = db.Select().ToString().ToUpper();
                  Timer1 = new Timer();
                  Timer1.Tick += new EventHandler(Timer1_Tick);
                  Timer1.Enabled = true;
              }
              catch (Exception ex) {
                  throw ex;
              }


              //Timer para atualizar o Dashborad de 1 em 1 minuto
              Timer = new Timer();
              Timer.Interval = 300000;
              Timer.Tick += new EventHandler(Timer_Tick);
              Timer.Enabled = true;

           


        }

        //Timer de Movimentação do Letreiro
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            this.Refresh();
            label2.UseCompatibleTextRendering = true;
            if (label2.Left < 0 && (Math.Abs(label2.Left) > label2.Width))
                label2.Left = this.Width;
            label2.Left -= 10;

        }

        //Timer de Atualizaçao Dados do Banco
        private void Timer_Tick(object Sender, EventArgs e) {

            db = new DbConnection();
            db.ConectarBanco();
            try
            {

                //Atualiza o letreiro do DashBoard
                db.ConectarBanco();
                label2.Text = "";
                label2.Text = db.Select().ToString().ToUpper();
                label2.UseCompatibleTextRendering = true;

                //Atualiza as imagens do DashBoard
                byte[] grafico = db.SelectImg();
                MemoryStream ms = new MemoryStream(grafico);
                Image ima = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = ima;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = ima;
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void marqueeLabel1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void marqueeLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void Testar_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void SairDoPrograma(object sender, KeyEventArgs e)
        {
            //Funções para sair do FullScreen com o Esc e para voltar com o F11
            if (e.KeyValue.Equals(27))
            {
                func1.voltarBarra(this);
                menuStrip1.Visible = true;
            } else if (e.KeyValue.Equals(122)) {
                menuStrip1.Visible = false;
                func1.fullScreen(this);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Settings.Default["IdDispositivo"] = 0;
            Settings.Default.Save();
            Form2 f = new Form2();
            f.Show();
            this.Refresh();*/
            Configuracoes conf = new Configuracoes();
            conf.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Settings.Default.CorLetreiro;
            label2.Font = Settings.Default.FonteLetreiro;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuporte suporte = new frmSuporte();
            suporte.ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            func1.fullScreen(this);
        }
    }
    /*
          //Rotina add imagen no banco só para teste
          Bitmap bitmap = new Bitmap(Properties.Resources.graf_1_);
          ImageConverter converter = new ImageConverter();

          byte[] img = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

          imgs = new Images();
          imgs.ConectarBanco();
          imgs.Save(img);
    */

}

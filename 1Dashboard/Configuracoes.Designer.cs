namespace _1Dashboard
{
    partial class Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbIdDisp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnTrocarFonte = new System.Windows.Forms.Button();
            this.btnTrocarCorFonte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIdDisp
            // 
            this.cmbIdDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdDisp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdDisp.FormattingEnabled = true;
            this.cmbIdDisp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbIdDisp.Location = new System.Drawing.Point(346, 49);
            this.cmbIdDisp.Name = "cmbIdDisp";
            this.cmbIdDisp.Size = new System.Drawing.Size(54, 27);
            this.cmbIdDisp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trocar ID do servidor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::_1Dashboard.Properties.Resources.configuration_250;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(150, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resetar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::_1Dashboard.Properties.Resources.cancellationbutton_exitneartheaction_botondecancelacion_salida_6335;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(416, 519);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 42);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Image = global::_1Dashboard.Properties.Resources.solicit_accept_check_ok_theaction_6340__1_;
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirma.Location = new System.Drawing.Point(12, 519);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(166, 42);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTrocarFonte
            // 
            this.btnTrocarFonte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarFonte.Image = global::_1Dashboard.Properties.Resources.font_symbol_of_letter_a_icon_icons_com_73556;
            this.btnTrocarFonte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocarFonte.Location = new System.Drawing.Point(150, 295);
            this.btnTrocarFonte.Name = "btnTrocarFonte";
            this.btnTrocarFonte.Size = new System.Drawing.Size(287, 50);
            this.btnTrocarFonte.TabIndex = 3;
            this.btnTrocarFonte.Text = "Trocar a fonte do letreiro";
            this.btnTrocarFonte.UseVisualStyleBackColor = true;
            this.btnTrocarFonte.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTrocarCorFonte
            // 
            this.btnTrocarCorFonte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarCorFonte.Image = global::_1Dashboard.Properties.Resources.color_wheel_16443;
            this.btnTrocarCorFonte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocarCorFonte.Location = new System.Drawing.Point(153, 179);
            this.btnTrocarCorFonte.Name = "btnTrocarCorFonte";
            this.btnTrocarCorFonte.Size = new System.Drawing.Size(284, 50);
            this.btnTrocarCorFonte.TabIndex = 2;
            this.btnTrocarCorFonte.Text = "Trocar a cor da fonte do letreiro";
            this.btnTrocarCorFonte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrocarCorFonte.UseVisualStyleBackColor = true;
            this.btnTrocarCorFonte.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnTrocarFonte);
            this.Controls.Add(this.btnTrocarCorFonte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdDisp);
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnTrocarCorFonte;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnTrocarFonte;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
    }
}
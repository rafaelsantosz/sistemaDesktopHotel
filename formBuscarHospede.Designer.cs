
namespace HotelTransilvania
{
    partial class formBuscarHospede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBuscarHospede));
            this.ajudaBusca = new System.Windows.Forms.PictureBox();
            this.TXTcelularHospede = new System.Windows.Forms.MaskedTextBox();
            this.TXTrgHospede = new System.Windows.Forms.MaskedTextBox();
            this.TXTcpfHospede = new System.Windows.Forms.MaskedTextBox();
            this.comboVipHospede = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNhospedeEscolhido = new System.Windows.Forms.PictureBox();
            this.TXTbuscarHospede = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataViewHospede = new System.Windows.Forms.DataGridView();
            this.TXTemailHospede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTenderecoHospede = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTnomeHospede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNhospedeEscolhido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHospede)).BeginInit();
            this.SuspendLayout();
            // 
            // ajudaBusca
            // 
            this.ajudaBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajudaBusca.Image = ((System.Drawing.Image)(resources.GetObject("ajudaBusca.Image")));
            this.ajudaBusca.Location = new System.Drawing.Point(694, 187);
            this.ajudaBusca.Name = "ajudaBusca";
            this.ajudaBusca.Size = new System.Drawing.Size(26, 25);
            this.ajudaBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBusca.TabIndex = 199;
            this.ajudaBusca.TabStop = false;
            this.ajudaBusca.Click += new System.EventHandler(this.ajudaBusca_Click);
            // 
            // TXTcelularHospede
            // 
            this.TXTcelularHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcelularHospede.Location = new System.Drawing.Point(340, 146);
            this.TXTcelularHospede.Mask = "(00) 00000-0000";
            this.TXTcelularHospede.Name = "TXTcelularHospede";
            this.TXTcelularHospede.Size = new System.Drawing.Size(125, 24);
            this.TXTcelularHospede.TabIndex = 198;
            this.TXTcelularHospede.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TXTrgHospede
            // 
            this.TXTrgHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTrgHospede.Location = new System.Drawing.Point(176, 92);
            this.TXTrgHospede.Mask = "00 000 000-0";
            this.TXTrgHospede.Name = "TXTrgHospede";
            this.TXTrgHospede.Size = new System.Drawing.Size(125, 24);
            this.TXTrgHospede.TabIndex = 197;
            this.TXTrgHospede.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TXTcpfHospede
            // 
            this.TXTcpfHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcpfHospede.Location = new System.Drawing.Point(27, 92);
            this.TXTcpfHospede.Mask = "000 000 000-00";
            this.TXTcpfHospede.Name = "TXTcpfHospede";
            this.TXTcpfHospede.Size = new System.Drawing.Size(125, 24);
            this.TXTcpfHospede.TabIndex = 196;
            this.TXTcpfHospede.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboVipHospede
            // 
            this.comboVipHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVipHospede.FormattingEnabled = true;
            this.comboVipHospede.Items.AddRange(new object[] {
            "S",
            "N"});
            this.comboVipHospede.Location = new System.Drawing.Point(502, 146);
            this.comboVipHospede.Name = "comboVipHospede";
            this.comboVipHospede.Size = new System.Drawing.Size(69, 26);
            this.comboVipHospede.TabIndex = 195;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 194;
            this.label8.Text = "VIP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 192;
            this.label7.Text = "RG:";
            // 
            // BTNhospedeEscolhido
            // 
            this.BTNhospedeEscolhido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNhospedeEscolhido.Image = ((System.Drawing.Image)(resources.GetObject("BTNhospedeEscolhido.Image")));
            this.BTNhospedeEscolhido.Location = new System.Drawing.Point(644, 59);
            this.BTNhospedeEscolhido.Name = "BTNhospedeEscolhido";
            this.BTNhospedeEscolhido.Size = new System.Drawing.Size(62, 57);
            this.BTNhospedeEscolhido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNhospedeEscolhido.TabIndex = 189;
            this.BTNhospedeEscolhido.TabStop = false;
            this.BTNhospedeEscolhido.Click += new System.EventHandler(this.BTNhospedeEscolhido_Click);
            // 
            // TXTbuscarHospede
            // 
            this.TXTbuscarHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTbuscarHospede.Location = new System.Drawing.Point(563, 187);
            this.TXTbuscarHospede.Name = "TXTbuscarHospede";
            this.TXTbuscarHospede.Size = new System.Drawing.Size(125, 24);
            this.TXTbuscarHospede.TabIndex = 188;
            this.TXTbuscarHospede.TextChanged += new System.EventHandler(this.TXTbuscarHospede_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 187;
            this.label3.Text = "Buscar:";
            // 
            // dataViewHospede
            // 
            this.dataViewHospede.AllowUserToAddRows = false;
            this.dataViewHospede.AllowUserToDeleteRows = false;
            this.dataViewHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewHospede.Location = new System.Drawing.Point(25, 218);
            this.dataViewHospede.Name = "dataViewHospede";
            this.dataViewHospede.ReadOnly = true;
            this.dataViewHospede.Size = new System.Drawing.Size(695, 143);
            this.dataViewHospede.TabIndex = 186;
            this.dataViewHospede.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewHospede_CellContentClick);
            // 
            // TXTemailHospede
            // 
            this.TXTemailHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTemailHospede.Location = new System.Drawing.Point(27, 146);
            this.TXTemailHospede.MaxLength = 50;
            this.TXTemailHospede.Name = "TXTemailHospede";
            this.TXTemailHospede.Size = new System.Drawing.Size(274, 24);
            this.TXTemailHospede.TabIndex = 185;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 184;
            this.label4.Text = "E-mail:";
            // 
            // TXTenderecoHospede
            // 
            this.TXTenderecoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTenderecoHospede.Location = new System.Drawing.Point(340, 36);
            this.TXTenderecoHospede.MaxLength = 50;
            this.TXTenderecoHospede.Multiline = true;
            this.TXTenderecoHospede.Name = "TXTenderecoHospede";
            this.TXTenderecoHospede.Size = new System.Drawing.Size(263, 80);
            this.TXTenderecoHospede.TabIndex = 183;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 182;
            this.label6.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 181;
            this.label5.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "CPF:";
            // 
            // TXTnomeHospede
            // 
            this.TXTnomeHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnomeHospede.Location = new System.Drawing.Point(27, 36);
            this.TXTnomeHospede.MaxLength = 50;
            this.TXTnomeHospede.Name = "TXTnomeHospede";
            this.TXTnomeHospede.Size = new System.Drawing.Size(274, 24);
            this.TXTnomeHospede.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 178;
            this.label1.Text = "Nome:";
            // 
            // formBuscarHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 373);
            this.Controls.Add(this.ajudaBusca);
            this.Controls.Add(this.TXTcelularHospede);
            this.Controls.Add(this.TXTrgHospede);
            this.Controls.Add(this.TXTcpfHospede);
            this.Controls.Add(this.comboVipHospede);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTNhospedeEscolhido);
            this.Controls.Add(this.TXTbuscarHospede);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataViewHospede);
            this.Controls.Add(this.TXTemailHospede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTenderecoHospede);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTnomeHospede);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBuscarHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Hóspede";
            this.Load += new System.EventHandler(this.formBuscarHospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNhospedeEscolhido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHospede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ajudaBusca;
        private System.Windows.Forms.MaskedTextBox TXTcelularHospede;
        private System.Windows.Forms.MaskedTextBox TXTrgHospede;
        private System.Windows.Forms.MaskedTextBox TXTcpfHospede;
        private System.Windows.Forms.ComboBox comboVipHospede;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BTNhospedeEscolhido;
        private System.Windows.Forms.TextBox TXTbuscarHospede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataViewHospede;
        private System.Windows.Forms.TextBox TXTemailHospede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTenderecoHospede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTnomeHospede;
        private System.Windows.Forms.Label label1;
    }
}
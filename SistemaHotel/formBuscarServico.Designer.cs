
namespace HotelTransilvania
{
    partial class formBuscarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBuscarServico));
            this.comboTipoServico = new System.Windows.Forms.ComboBox();
            this.TXTdetalhesServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTvalorServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNservicoEscolhido = new System.Windows.Forms.PictureBox();
            this.TXTbuscarServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataViewServico = new System.Windows.Forms.DataGridView();
            this.TXTservico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ajudaBusca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTNservicoEscolhido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTipoServico
            // 
            this.comboTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoServico.FormattingEnabled = true;
            this.comboTipoServico.Items.AddRange(new object[] {
            "Comida",
            "Bebida",
            "Geral"});
            this.comboTipoServico.Location = new System.Drawing.Point(21, 93);
            this.comboTipoServico.Name = "comboTipoServico";
            this.comboTipoServico.Size = new System.Drawing.Size(125, 26);
            this.comboTipoServico.TabIndex = 217;
            // 
            // TXTdetalhesServico
            // 
            this.TXTdetalhesServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTdetalhesServico.Location = new System.Drawing.Point(318, 37);
            this.TXTdetalhesServico.Multiline = true;
            this.TXTdetalhesServico.Name = "TXTdetalhesServico";
            this.TXTdetalhesServico.Size = new System.Drawing.Size(263, 80);
            this.TXTdetalhesServico.TabIndex = 215;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 214;
            this.label6.Text = "Detalhes:";
            // 
            // TXTvalorServico
            // 
            this.TXTvalorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTvalorServico.Location = new System.Drawing.Point(174, 93);
            this.TXTvalorServico.Name = "TXTvalorServico";
            this.TXTvalorServico.Size = new System.Drawing.Size(125, 24);
            this.TXTvalorServico.TabIndex = 213;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 212;
            this.label4.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 211;
            this.label7.Text = "Tipo:";
            // 
            // BTNservicoEscolhido
            // 
            this.BTNservicoEscolhido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNservicoEscolhido.Image = ((System.Drawing.Image)(resources.GetObject("BTNservicoEscolhido.Image")));
            this.BTNservicoEscolhido.Location = new System.Drawing.Point(603, 50);
            this.BTNservicoEscolhido.Name = "BTNservicoEscolhido";
            this.BTNservicoEscolhido.Size = new System.Drawing.Size(62, 57);
            this.BTNservicoEscolhido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNservicoEscolhido.TabIndex = 207;
            this.BTNservicoEscolhido.TabStop = false;
            this.BTNservicoEscolhido.Click += new System.EventHandler(this.BTNservicoEscolhido_Click);
            // 
            // TXTbuscarServico
            // 
            this.TXTbuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTbuscarServico.Location = new System.Drawing.Point(508, 142);
            this.TXTbuscarServico.Name = "TXTbuscarServico";
            this.TXTbuscarServico.Size = new System.Drawing.Size(125, 24);
            this.TXTbuscarServico.TabIndex = 206;
            this.TXTbuscarServico.TextChanged += new System.EventHandler(this.TXTbuscarServico_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 205;
            this.label3.Text = "Buscar:";
            // 
            // dataViewServico
            // 
            this.dataViewServico.AllowUserToAddRows = false;
            this.dataViewServico.AllowUserToDeleteRows = false;
            this.dataViewServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServico.Location = new System.Drawing.Point(21, 172);
            this.dataViewServico.Name = "dataViewServico";
            this.dataViewServico.ReadOnly = true;
            this.dataViewServico.Size = new System.Drawing.Size(644, 143);
            this.dataViewServico.TabIndex = 204;
            this.dataViewServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewServico_CellContentClick);
            // 
            // TXTservico
            // 
            this.TXTservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTservico.Location = new System.Drawing.Point(21, 37);
            this.TXTservico.Name = "TXTservico";
            this.TXTservico.Size = new System.Drawing.Size(278, 24);
            this.TXTservico.TabIndex = 203;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 202;
            this.label2.Text = "Serviço:";
            // 
            // ajudaBusca
            // 
            this.ajudaBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajudaBusca.Image = ((System.Drawing.Image)(resources.GetObject("ajudaBusca.Image")));
            this.ajudaBusca.Location = new System.Drawing.Point(639, 141);
            this.ajudaBusca.Name = "ajudaBusca";
            this.ajudaBusca.Size = new System.Drawing.Size(26, 25);
            this.ajudaBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBusca.TabIndex = 253;
            this.ajudaBusca.TabStop = false;
            this.ajudaBusca.Click += new System.EventHandler(this.ajudaBusca_Click);
            // 
            // formBuscarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 334);
            this.Controls.Add(this.ajudaBusca);
            this.Controls.Add(this.comboTipoServico);
            this.Controls.Add(this.TXTdetalhesServico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTvalorServico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTNservicoEscolhido);
            this.Controls.Add(this.TXTbuscarServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataViewServico);
            this.Controls.Add(this.TXTservico);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBuscarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Serviço";
            this.Load += new System.EventHandler(this.formBuscarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTNservicoEscolhido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTipoServico;
        private System.Windows.Forms.TextBox TXTdetalhesServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTvalorServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BTNservicoEscolhido;
        private System.Windows.Forms.TextBox TXTbuscarServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataViewServico;
        private System.Windows.Forms.TextBox TXTservico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ajudaBusca;
    }
}
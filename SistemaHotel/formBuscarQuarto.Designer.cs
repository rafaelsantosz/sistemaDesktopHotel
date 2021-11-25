
namespace HotelTransilvania
{
    partial class formBuscarQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBuscarQuarto));
            this.TXTvalorQuarto = new System.Windows.Forms.MaskedTextBox();
            this.ajudaBusca = new System.Windows.Forms.PictureBox();
            this.comboTipoQuarto = new System.Windows.Forms.ComboBox();
            this.comboQuartoDisponivel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTdetalhesQuarto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNquartoEscolhido = new System.Windows.Forms.PictureBox();
            this.TXTbuscarQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataViewQuarto = new System.Windows.Forms.DataGridView();
            this.TXTnumeroQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNquartoEscolhido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTvalorQuarto
            // 
            this.TXTvalorQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTvalorQuarto.Location = new System.Drawing.Point(23, 96);
            this.TXTvalorQuarto.Name = "TXTvalorQuarto";
            this.TXTvalorQuarto.Size = new System.Drawing.Size(125, 24);
            this.TXTvalorQuarto.TabIndex = 197;
            // 
            // ajudaBusca
            // 
            this.ajudaBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajudaBusca.Image = ((System.Drawing.Image)(resources.GetObject("ajudaBusca.Image")));
            this.ajudaBusca.Location = new System.Drawing.Point(659, 156);
            this.ajudaBusca.Name = "ajudaBusca";
            this.ajudaBusca.Size = new System.Drawing.Size(26, 25);
            this.ajudaBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBusca.TabIndex = 196;
            this.ajudaBusca.TabStop = false;
            this.ajudaBusca.Click += new System.EventHandler(this.ajudaBusca_Click);
            // 
            // comboTipoQuarto
            // 
            this.comboTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoQuarto.FormattingEnabled = true;
            this.comboTipoQuarto.Items.AddRange(new object[] {
            "Simples",
            "Casal",
            "Familiar",
            "Luxo"});
            this.comboTipoQuarto.Location = new System.Drawing.Point(176, 40);
            this.comboTipoQuarto.Name = "comboTipoQuarto";
            this.comboTipoQuarto.Size = new System.Drawing.Size(125, 26);
            this.comboTipoQuarto.TabIndex = 195;
            // 
            // comboQuartoDisponivel
            // 
            this.comboQuartoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuartoDisponivel.FormattingEnabled = true;
            this.comboQuartoDisponivel.Items.AddRange(new object[] {
            "S",
            "N"});
            this.comboQuartoDisponivel.Location = new System.Drawing.Point(176, 94);
            this.comboQuartoDisponivel.Name = "comboQuartoDisponivel";
            this.comboQuartoDisponivel.Size = new System.Drawing.Size(69, 26);
            this.comboQuartoDisponivel.TabIndex = 194;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 193;
            this.label8.Text = "Disponível:";
            // 
            // TXTdetalhesQuarto
            // 
            this.TXTdetalhesQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTdetalhesQuarto.Location = new System.Drawing.Point(318, 40);
            this.TXTdetalhesQuarto.MaxLength = 50;
            this.TXTdetalhesQuarto.Multiline = true;
            this.TXTdetalhesQuarto.Name = "TXTdetalhesQuarto";
            this.TXTdetalhesQuarto.Size = new System.Drawing.Size(263, 80);
            this.TXTdetalhesQuarto.TabIndex = 191;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 190;
            this.label6.Text = "Detalhes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 189;
            this.label4.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 188;
            this.label7.Text = "Tipo:";
            // 
            // BTNquartoEscolhido
            // 
            this.BTNquartoEscolhido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNquartoEscolhido.Image = ((System.Drawing.Image)(resources.GetObject("BTNquartoEscolhido.Image")));
            this.BTNquartoEscolhido.Location = new System.Drawing.Point(603, 50);
            this.BTNquartoEscolhido.Name = "BTNquartoEscolhido";
            this.BTNquartoEscolhido.Size = new System.Drawing.Size(62, 57);
            this.BTNquartoEscolhido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNquartoEscolhido.TabIndex = 185;
            this.BTNquartoEscolhido.TabStop = false;
            this.BTNquartoEscolhido.Click += new System.EventHandler(this.BTNquartoEscolhido_Click);
            // 
            // TXTbuscarQuarto
            // 
            this.TXTbuscarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTbuscarQuarto.Location = new System.Drawing.Point(528, 157);
            this.TXTbuscarQuarto.Name = "TXTbuscarQuarto";
            this.TXTbuscarQuarto.Size = new System.Drawing.Size(125, 24);
            this.TXTbuscarQuarto.TabIndex = 184;
            this.TXTbuscarQuarto.TextChanged += new System.EventHandler(this.TXTbuscarQuarto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 183;
            this.label3.Text = "Buscar:";
            // 
            // dataViewQuarto
            // 
            this.dataViewQuarto.AllowUserToAddRows = false;
            this.dataViewQuarto.AllowUserToDeleteRows = false;
            this.dataViewQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewQuarto.Location = new System.Drawing.Point(23, 187);
            this.dataViewQuarto.Name = "dataViewQuarto";
            this.dataViewQuarto.ReadOnly = true;
            this.dataViewQuarto.Size = new System.Drawing.Size(662, 143);
            this.dataViewQuarto.TabIndex = 182;
            this.dataViewQuarto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewQuarto_CellContentClick);
            // 
            // TXTnumeroQuarto
            // 
            this.TXTnumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnumeroQuarto.Location = new System.Drawing.Point(23, 40);
            this.TXTnumeroQuarto.Name = "TXTnumeroQuarto";
            this.TXTnumeroQuarto.Size = new System.Drawing.Size(125, 24);
            this.TXTnumeroQuarto.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "Número:";
            // 
            // formBuscarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 342);
            this.Controls.Add(this.TXTvalorQuarto);
            this.Controls.Add(this.ajudaBusca);
            this.Controls.Add(this.comboTipoQuarto);
            this.Controls.Add(this.comboQuartoDisponivel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTdetalhesQuarto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTNquartoEscolhido);
            this.Controls.Add(this.TXTbuscarQuarto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataViewQuarto);
            this.Controls.Add(this.TXTnumeroQuarto);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBuscarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Quarto";
            this.Load += new System.EventHandler(this.formBuscarQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNquartoEscolhido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TXTvalorQuarto;
        private System.Windows.Forms.PictureBox ajudaBusca;
        private System.Windows.Forms.ComboBox comboTipoQuarto;
        private System.Windows.Forms.ComboBox comboQuartoDisponivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTdetalhesQuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BTNquartoEscolhido;
        private System.Windows.Forms.TextBox TXTbuscarQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataViewQuarto;
        private System.Windows.Forms.TextBox TXTnumeroQuarto;
        private System.Windows.Forms.Label label2;
    }
}
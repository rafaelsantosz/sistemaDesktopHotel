
namespace HotelTransilvania
{
    partial class formMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuPrincipal));
            this.linkCheckOut = new System.Windows.Forms.LinkLabel();
            this.linkHospedagens = new System.Windows.Forms.LinkLabel();
            this.linkHospedes = new System.Windows.Forms.LinkLabel();
            this.acessoCheckOut = new System.Windows.Forms.PictureBox();
            this.acessoHospedes = new System.Windows.Forms.PictureBox();
            this.acessoHospedagens = new System.Windows.Forms.PictureBox();
            this.menuOpcoes = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHospede = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHospedagem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGerenciar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuarto = new System.Windows.Forms.ToolStripMenuItem();
            this.itemServico = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInformacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkServicos = new System.Windows.Forms.LinkLabel();
            this.linkQuartos = new System.Windows.Forms.LinkLabel();
            this.linkFuncionarios = new System.Windows.Forms.LinkLabel();
            this.acessoFuncionarios = new System.Windows.Forms.PictureBox();
            this.acessoServicos = new System.Windows.Forms.PictureBox();
            this.acessoQuartos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataViewCheckOut = new System.Windows.Forms.DataGridView();
            this.dataViewCheckIn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blocoFuncionarioLogado = new System.Windows.Forms.GroupBox();
            this.horaAtual = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.horaLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTcargo = new System.Windows.Forms.Label();
            this.TXTnomeFuncionario = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkVendas = new System.Windows.Forms.LinkLabel();
            this.acessoVendas = new System.Windows.Forms.PictureBox();
            this.atualizarDataView = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.acessoCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoHospedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoHospedagens)).BeginInit();
            this.menuOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCheckIn)).BeginInit();
            this.blocoFuncionarioLogado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizarDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // linkCheckOut
            // 
            this.linkCheckOut.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkCheckOut.AutoSize = true;
            this.linkCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCheckOut.LinkColor = System.Drawing.Color.Black;
            this.linkCheckOut.Location = new System.Drawing.Point(329, 203);
            this.linkCheckOut.Name = "linkCheckOut";
            this.linkCheckOut.Size = new System.Drawing.Size(70, 16);
            this.linkCheckOut.TabIndex = 36;
            this.linkCheckOut.TabStop = true;
            this.linkCheckOut.Text = "Check-Out";
            this.linkCheckOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkCheckOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckOut_LinkClicked);
            // 
            // linkHospedagens
            // 
            this.linkHospedagens.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkHospedagens.AutoSize = true;
            this.linkHospedagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHospedagens.LinkColor = System.Drawing.Color.Black;
            this.linkHospedagens.Location = new System.Drawing.Point(180, 203);
            this.linkHospedagens.Name = "linkHospedagens";
            this.linkHospedagens.Size = new System.Drawing.Size(95, 16);
            this.linkHospedagens.TabIndex = 34;
            this.linkHospedagens.TabStop = true;
            this.linkHospedagens.Text = "Hospedagens";
            this.linkHospedagens.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkHospedagens.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHospedagens_LinkClicked);
            // 
            // linkHospedes
            // 
            this.linkHospedes.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkHospedes.AutoSize = true;
            this.linkHospedes.BackColor = System.Drawing.Color.Transparent;
            this.linkHospedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHospedes.LinkColor = System.Drawing.Color.Black;
            this.linkHospedes.Location = new System.Drawing.Point(46, 203);
            this.linkHospedes.Name = "linkHospedes";
            this.linkHospedes.Size = new System.Drawing.Size(72, 16);
            this.linkHospedes.TabIndex = 33;
            this.linkHospedes.TabStop = true;
            this.linkHospedes.Text = "Hóspedes";
            this.linkHospedes.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkHospedes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHospedes_LinkClicked);
            // 
            // acessoCheckOut
            // 
            this.acessoCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("acessoCheckOut.Image")));
            this.acessoCheckOut.Location = new System.Drawing.Point(318, 109);
            this.acessoCheckOut.Name = "acessoCheckOut";
            this.acessoCheckOut.Size = new System.Drawing.Size(100, 91);
            this.acessoCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoCheckOut.TabIndex = 32;
            this.acessoCheckOut.TabStop = false;
            this.acessoCheckOut.Click += new System.EventHandler(this.acessoCheckOut_Click);
            // 
            // acessoHospedes
            // 
            this.acessoHospedes.BackColor = System.Drawing.Color.Transparent;
            this.acessoHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoHospedes.Image = ((System.Drawing.Image)(resources.GetObject("acessoHospedes.Image")));
            this.acessoHospedes.Location = new System.Drawing.Point(28, 109);
            this.acessoHospedes.Name = "acessoHospedes";
            this.acessoHospedes.Size = new System.Drawing.Size(100, 91);
            this.acessoHospedes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoHospedes.TabIndex = 30;
            this.acessoHospedes.TabStop = false;
            this.acessoHospedes.Click += new System.EventHandler(this.acessoHospedes_Click);
            // 
            // acessoHospedagens
            // 
            this.acessoHospedagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoHospedagens.Image = ((System.Drawing.Image)(resources.GetObject("acessoHospedagens.Image")));
            this.acessoHospedagens.Location = new System.Drawing.Point(175, 109);
            this.acessoHospedagens.Name = "acessoHospedagens";
            this.acessoHospedagens.Size = new System.Drawing.Size(100, 91);
            this.acessoHospedagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoHospedagens.TabIndex = 29;
            this.acessoHospedagens.TabStop = false;
            this.acessoHospedagens.Click += new System.EventHandler(this.acessoHospedagens_Click);
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.BackColor = System.Drawing.Color.CadetBlue;
            this.menuOpcoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuGerenciar,
            this.menuUsuario,
            this.menuSair});
            this.menuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(1370, 33);
            this.menuOpcoes.TabIndex = 37;
            this.menuOpcoes.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHospede,
            this.itemHospedagem,
            this.checkOutToolStripMenuItem});
            this.menuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastros.Image")));
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(121, 29);
            this.menuCadastros.Text = "Cadastrar";
            // 
            // itemHospede
            // 
            this.itemHospede.Image = ((System.Drawing.Image)(resources.GetObject("itemHospede.Image")));
            this.itemHospede.Name = "itemHospede";
            this.itemHospede.Size = new System.Drawing.Size(195, 30);
            this.itemHospede.Text = "Hóspede";
            this.itemHospede.Click += new System.EventHandler(this.itemHospede_Click);
            // 
            // itemHospedagem
            // 
            this.itemHospedagem.Image = ((System.Drawing.Image)(resources.GetObject("itemHospedagem.Image")));
            this.itemHospedagem.Name = "itemHospedagem";
            this.itemHospedagem.Size = new System.Drawing.Size(195, 30);
            this.itemHospedagem.Text = "Hospedagem";
            this.itemHospedagem.Click += new System.EventHandler(this.itemHospedagem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkOutToolStripMenuItem.Image")));
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // menuGerenciar
            // 
            this.menuGerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemQuarto,
            this.itemServico,
            this.itemVenda,
            this.itemFuncionario});
            this.menuGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("menuGerenciar.Image")));
            this.menuGerenciar.Name = "menuGerenciar";
            this.menuGerenciar.Size = new System.Drawing.Size(122, 29);
            this.menuGerenciar.Text = "Gerenciar";
            // 
            // itemQuarto
            // 
            this.itemQuarto.Image = ((System.Drawing.Image)(resources.GetObject("itemQuarto.Image")));
            this.itemQuarto.Name = "itemQuarto";
            this.itemQuarto.Size = new System.Drawing.Size(184, 30);
            this.itemQuarto.Text = "Quarto";
            this.itemQuarto.Click += new System.EventHandler(this.itemQuarto_Click);
            // 
            // itemServico
            // 
            this.itemServico.Image = ((System.Drawing.Image)(resources.GetObject("itemServico.Image")));
            this.itemServico.Name = "itemServico";
            this.itemServico.Size = new System.Drawing.Size(184, 30);
            this.itemServico.Text = "Serviço";
            this.itemServico.Click += new System.EventHandler(this.itemServico_Click);
            // 
            // itemVenda
            // 
            this.itemVenda.Image = ((System.Drawing.Image)(resources.GetObject("itemVenda.Image")));
            this.itemVenda.Name = "itemVenda";
            this.itemVenda.Size = new System.Drawing.Size(184, 30);
            this.itemVenda.Text = "Venda";
            this.itemVenda.Click += new System.EventHandler(this.itemVenda_Click);
            // 
            // itemFuncionario
            // 
            this.itemFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("itemFuncionario.Image")));
            this.itemFuncionario.Name = "itemFuncionario";
            this.itemFuncionario.Size = new System.Drawing.Size(184, 30);
            this.itemFuncionario.Text = "Funcionário";
            this.itemFuncionario.Click += new System.EventHandler(this.itemFuncionario_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInformacoes});
            this.menuUsuario.Image = ((System.Drawing.Image)(resources.GetObject("menuUsuario.Image")));
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(105, 29);
            this.menuUsuario.Text = "Usuário";
            // 
            // itemInformacoes
            // 
            this.itemInformacoes.Image = ((System.Drawing.Image)(resources.GetObject("itemInformacoes.Image")));
            this.itemInformacoes.Name = "itemInformacoes";
            this.itemInformacoes.Size = new System.Drawing.Size(188, 30);
            this.itemInformacoes.Text = "Informações";
            this.itemInformacoes.Click += new System.EventHandler(this.itemInformacoes_Click);
            // 
            // menuSair
            // 
            this.menuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFechar});
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(72, 29);
            this.menuSair.Text = "Sair";
            // 
            // itemFechar
            // 
            this.itemFechar.Image = ((System.Drawing.Image)(resources.GetObject("itemFechar.Image")));
            this.itemFechar.Name = "itemFechar";
            this.itemFechar.Size = new System.Drawing.Size(140, 30);
            this.itemFechar.Text = "Fechar";
            this.itemFechar.Click += new System.EventHandler(this.itemFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cadastros";
            // 
            // linkServicos
            // 
            this.linkServicos.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkServicos.AutoSize = true;
            this.linkServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkServicos.LinkColor = System.Drawing.Color.Black;
            this.linkServicos.Location = new System.Drawing.Point(195, 388);
            this.linkServicos.Name = "linkServicos";
            this.linkServicos.Size = new System.Drawing.Size(61, 16);
            this.linkServicos.TabIndex = 46;
            this.linkServicos.TabStop = true;
            this.linkServicos.Text = "Serviços";
            this.linkServicos.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkServicos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkServicos_LinkClicked);
            // 
            // linkQuartos
            // 
            this.linkQuartos.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkQuartos.AutoSize = true;
            this.linkQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQuartos.LinkColor = System.Drawing.Color.Black;
            this.linkQuartos.Location = new System.Drawing.Point(46, 388);
            this.linkQuartos.Name = "linkQuartos";
            this.linkQuartos.Size = new System.Drawing.Size(55, 16);
            this.linkQuartos.TabIndex = 44;
            this.linkQuartos.TabStop = true;
            this.linkQuartos.Text = "Quartos";
            this.linkQuartos.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkQuartos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuartos_LinkClicked);
            // 
            // linkFuncionarios
            // 
            this.linkFuncionarios.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkFuncionarios.AutoSize = true;
            this.linkFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFuncionarios.LinkColor = System.Drawing.Color.Black;
            this.linkFuncionarios.Location = new System.Drawing.Point(466, 388);
            this.linkFuncionarios.Name = "linkFuncionarios";
            this.linkFuncionarios.Size = new System.Drawing.Size(85, 16);
            this.linkFuncionarios.TabIndex = 43;
            this.linkFuncionarios.TabStop = true;
            this.linkFuncionarios.Text = "Funcionários";
            this.linkFuncionarios.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkFuncionarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFuncionarios_LinkClicked);
            // 
            // acessoFuncionarios
            // 
            this.acessoFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("acessoFuncionarios.Image")));
            this.acessoFuncionarios.Location = new System.Drawing.Point(458, 294);
            this.acessoFuncionarios.Name = "acessoFuncionarios";
            this.acessoFuncionarios.Size = new System.Drawing.Size(100, 91);
            this.acessoFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoFuncionarios.TabIndex = 42;
            this.acessoFuncionarios.TabStop = false;
            this.acessoFuncionarios.Click += new System.EventHandler(this.acessoFuncionarios_Click);
            // 
            // acessoServicos
            // 
            this.acessoServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoServicos.Image = ((System.Drawing.Image)(resources.GetObject("acessoServicos.Image")));
            this.acessoServicos.Location = new System.Drawing.Point(175, 294);
            this.acessoServicos.Name = "acessoServicos";
            this.acessoServicos.Size = new System.Drawing.Size(100, 91);
            this.acessoServicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoServicos.TabIndex = 41;
            this.acessoServicos.TabStop = false;
            this.acessoServicos.Click += new System.EventHandler(this.acessoServicos_Click);
            // 
            // acessoQuartos
            // 
            this.acessoQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoQuartos.Image = ((System.Drawing.Image)(resources.GetObject("acessoQuartos.Image")));
            this.acessoQuartos.Location = new System.Drawing.Point(28, 294);
            this.acessoQuartos.Name = "acessoQuartos";
            this.acessoQuartos.Size = new System.Drawing.Size(100, 91);
            this.acessoQuartos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoQuartos.TabIndex = 39;
            this.acessoQuartos.TabStop = false;
            this.acessoQuartos.Click += new System.EventHandler(this.acessoQuartos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Gerenciamento";
            // 
            // dataViewCheckOut
            // 
            this.dataViewCheckOut.AllowUserToAddRows = false;
            this.dataViewCheckOut.AllowUserToDeleteRows = false;
            this.dataViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCheckOut.Location = new System.Drawing.Point(524, 494);
            this.dataViewCheckOut.Name = "dataViewCheckOut";
            this.dataViewCheckOut.ReadOnly = true;
            this.dataViewCheckOut.Size = new System.Drawing.Size(435, 233);
            this.dataViewCheckOut.TabIndex = 49;
            // 
            // dataViewCheckIn
            // 
            this.dataViewCheckIn.AllowUserToAddRows = false;
            this.dataViewCheckIn.AllowUserToDeleteRows = false;
            this.dataViewCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCheckIn.Location = new System.Drawing.Point(18, 494);
            this.dataViewCheckIn.Name = "dataViewCheckIn";
            this.dataViewCheckIn.ReadOnly = true;
            this.dataViewCheckIn.Size = new System.Drawing.Size(435, 233);
            this.dataViewCheckIn.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "CHECK-IN (hospedados)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "CHECK-OUT (saídas)";
            // 
            // blocoFuncionarioLogado
            // 
            this.blocoFuncionarioLogado.BackColor = System.Drawing.Color.GhostWhite;
            this.blocoFuncionarioLogado.Controls.Add(this.horaAtual);
            this.blocoFuncionarioLogado.Controls.Add(this.label6);
            this.blocoFuncionarioLogado.Controls.Add(this.horaLogin);
            this.blocoFuncionarioLogado.Controls.Add(this.label5);
            this.blocoFuncionarioLogado.Controls.Add(this.TXTcargo);
            this.blocoFuncionarioLogado.Controls.Add(this.TXTnomeFuncionario);
            this.blocoFuncionarioLogado.Controls.Add(this.pictureBox4);
            this.blocoFuncionarioLogado.Controls.Add(this.pictureBox3);
            this.blocoFuncionarioLogado.Controls.Add(this.pictureBox2);
            this.blocoFuncionarioLogado.Controls.Add(this.pictureBox1);
            this.blocoFuncionarioLogado.Controls.Add(this.label10);
            this.blocoFuncionarioLogado.Controls.Add(this.label11);
            this.blocoFuncionarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocoFuncionarioLogado.Location = new System.Drawing.Point(992, 72);
            this.blocoFuncionarioLogado.Name = "blocoFuncionarioLogado";
            this.blocoFuncionarioLogado.Size = new System.Drawing.Size(336, 268);
            this.blocoFuncionarioLogado.TabIndex = 52;
            this.blocoFuncionarioLogado.TabStop = false;
            this.blocoFuncionarioLogado.Text = "Funcionário Logado";
            // 
            // horaAtual
            // 
            this.horaAtual.AutoSize = true;
            this.horaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaAtual.Location = new System.Drawing.Point(168, 200);
            this.horaAtual.Name = "horaAtual";
            this.horaAtual.Size = new System.Drawing.Size(80, 24);
            this.horaAtual.TabIndex = 76;
            this.horaAtual.Text = "12:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 75;
            this.label6.Text = "Horário Atual:";
            // 
            // horaLogin
            // 
            this.horaLogin.AutoSize = true;
            this.horaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLogin.Location = new System.Drawing.Point(201, 156);
            this.horaLogin.Name = "horaLogin";
            this.horaLogin.Size = new System.Drawing.Size(80, 24);
            this.horaLogin.TabIndex = 74;
            this.horaLogin.Text = "12:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Horário de Login:";
            // 
            // TXTcargo
            // 
            this.TXTcargo.AutoSize = true;
            this.TXTcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcargo.Location = new System.Drawing.Point(111, 112);
            this.TXTcargo.Name = "TXTcargo";
            this.TXTcargo.Size = new System.Drawing.Size(61, 24);
            this.TXTcargo.TabIndex = 72;
            this.TXTcargo.Text = "Cargo";
            // 
            // TXTnomeFuncionario
            // 
            this.TXTnomeFuncionario.AutoSize = true;
            this.TXTnomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnomeFuncionario.Location = new System.Drawing.Point(111, 71);
            this.TXTnomeFuncionario.Name = "TXTnomeFuncionario";
            this.TXTnomeFuncionario.Size = new System.Drawing.Size(111, 24);
            this.TXTnomeFuncionario.TabIndex = 71;
            this.TXTnomeFuncionario.Text = "Funcionário";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 200);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 68;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 62;
            this.label10.Text = "Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Nome:";
            // 
            // linkVendas
            // 
            this.linkVendas.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkVendas.AutoSize = true;
            this.linkVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVendas.LinkColor = System.Drawing.Color.Black;
            this.linkVendas.Location = new System.Drawing.Point(344, 388);
            this.linkVendas.Name = "linkVendas";
            this.linkVendas.Size = new System.Drawing.Size(55, 16);
            this.linkVendas.TabIndex = 54;
            this.linkVendas.TabStop = true;
            this.linkVendas.Text = "Vendas";
            this.linkVendas.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkVendas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVendas_LinkClicked);
            // 
            // acessoVendas
            // 
            this.acessoVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acessoVendas.Image = ((System.Drawing.Image)(resources.GetObject("acessoVendas.Image")));
            this.acessoVendas.Location = new System.Drawing.Point(318, 294);
            this.acessoVendas.Name = "acessoVendas";
            this.acessoVendas.Size = new System.Drawing.Size(100, 91);
            this.acessoVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acessoVendas.TabIndex = 53;
            this.acessoVendas.TabStop = false;
            this.acessoVendas.Click += new System.EventHandler(this.acessoVendas_Click);
            // 
            // atualizarDataView
            // 
            this.atualizarDataView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atualizarDataView.Image = ((System.Drawing.Image)(resources.GetObject("atualizarDataView.Image")));
            this.atualizarDataView.Location = new System.Drawing.Point(472, 594);
            this.atualizarDataView.Name = "atualizarDataView";
            this.atualizarDataView.Size = new System.Drawing.Size(35, 35);
            this.atualizarDataView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atualizarDataView.TabIndex = 235;
            this.atualizarDataView.TabStop = false;
            this.atualizarDataView.Click += new System.EventHandler(this.atualizarDataView_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1007, 357);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(307, 170);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 236;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1007, 543);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(307, 184);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 237;
            this.pictureBox6.TabStop = false;
            // 
            // formMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.atualizarDataView);
            this.Controls.Add(this.linkVendas);
            this.Controls.Add(this.acessoVendas);
            this.Controls.Add(this.blocoFuncionarioLogado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataViewCheckOut);
            this.Controls.Add(this.dataViewCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkServicos);
            this.Controls.Add(this.linkQuartos);
            this.Controls.Add(this.linkFuncionarios);
            this.Controls.Add(this.acessoFuncionarios);
            this.Controls.Add(this.acessoServicos);
            this.Controls.Add(this.acessoQuartos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkCheckOut);
            this.Controls.Add(this.linkHospedagens);
            this.Controls.Add(this.linkHospedes);
            this.Controls.Add(this.acessoCheckOut);
            this.Controls.Add(this.acessoHospedes);
            this.Controls.Add(this.acessoHospedagens);
            this.Controls.Add(this.menuOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpcoes;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Transilvânia - Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acessoCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoHospedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoHospedagens)).EndInit();
            this.menuOpcoes.ResumeLayout(false);
            this.menuOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCheckIn)).EndInit();
            this.blocoFuncionarioLogado.ResumeLayout(false);
            this.blocoFuncionarioLogado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizarDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkCheckOut;
        private System.Windows.Forms.LinkLabel linkHospedagens;
        private System.Windows.Forms.LinkLabel linkHospedes;
        private System.Windows.Forms.PictureBox acessoCheckOut;
        private System.Windows.Forms.PictureBox acessoHospedes;
        private System.Windows.Forms.PictureBox acessoHospedagens;
        private System.Windows.Forms.MenuStrip menuOpcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkServicos;
        private System.Windows.Forms.LinkLabel linkQuartos;
        private System.Windows.Forms.LinkLabel linkFuncionarios;
        private System.Windows.Forms.PictureBox acessoFuncionarios;
        private System.Windows.Forms.PictureBox acessoServicos;
        private System.Windows.Forms.PictureBox acessoQuartos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataViewCheckOut;
        private System.Windows.Forms.DataGridView dataViewCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox blocoFuncionarioLogado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem itemHospede;
        private System.Windows.Forms.ToolStripMenuItem itemHospedagem;
        private System.Windows.Forms.ToolStripMenuItem menuGerenciar;
        private System.Windows.Forms.ToolStripMenuItem itemQuarto;
        private System.Windows.Forms.ToolStripMenuItem itemServico;
        private System.Windows.Forms.ToolStripMenuItem itemFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem itemInformacoes;
        private System.Windows.Forms.ToolStripMenuItem itemFechar;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemVenda;
        private System.Windows.Forms.LinkLabel linkVendas;
        private System.Windows.Forms.PictureBox acessoVendas;
        private System.Windows.Forms.PictureBox atualizarDataView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TXTcargo;
        private System.Windows.Forms.Label TXTnomeFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label horaLogin;
        private System.Windows.Forms.Label horaAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
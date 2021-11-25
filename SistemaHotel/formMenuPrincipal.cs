using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransilvania
{
    public partial class formMenuPrincipal : Form
    {
        public string nomeFuncionario { get; set; }
        public string cargoFuncionario { get; set; }
        public string telefoneFuncionario { get; set; }
        public string emailFuncionario { get; set; }
        public string loginFuncionario { get; set; }
        public string senhaFuncionario { get; set; }

        public formMenuPrincipal(string nome, string cargo, string telefone, string email, string login, string senha)
        {
            InitializeComponent();
            TXTnomeFuncionario.Text = nome;
            nomeFuncionario = nome;
            TXTcargo.Text = cargo;
            cargoFuncionario = cargo;
            telefoneFuncionario = telefone;
            emailFuncionario = email;
            loginFuncionario = login;
            senhaFuncionario = senha;

            if (cargo != "Administrador")
            {
                itemQuarto.Enabled = false;
                itemServico.Enabled = false;
                itemFuncionario.Enabled = false;
                acessoQuartos.Enabled = false;
                linkQuartos.Enabled = false;
                acessoServicos.Enabled = false;
                linkServicos.Enabled = false;
                acessoFuncionarios.Enabled = false;
                linkFuncionarios.Enabled = false;
            }
        }

        private void linkServicos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formServico telaServico = new formServico();
            telaServico.ShowDialog();
        }

        private void linkQuartos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formQuarto telaQuarto = new formQuarto();
            telaQuarto.ShowDialog();
        }

        private void itemHospede_Click(object sender, EventArgs e)
        {
            formHospede telaHospede = new formHospede();
            telaHospede.ShowDialog();
        }

        private void acessoHospedes_Click(object sender, EventArgs e)
        {
            formHospede telaHospede = new formHospede();
            telaHospede.ShowDialog();
        }

        private void linkHospedes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHospede telaHospede = new formHospede();
            telaHospede.ShowDialog();
        }

        private void itemHospedagem_Click(object sender, EventArgs e)
        {
            formHospedagem telaHospedagem = new formHospedagem();
            telaHospedagem.ShowDialog();
        }

        private void acessoHospedagens_Click(object sender, EventArgs e)
        {
            formHospedagem telaHospedagem = new formHospedagem();
            telaHospedagem.ShowDialog();
        }

        private void linkHospedagens_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHospedagem telaHospedagem = new formHospedagem();
            telaHospedagem.ShowDialog();
        }

        private void acessoQuartos_Click(object sender, EventArgs e)
        {
            formQuarto telaQuarto = new formQuarto();
            telaQuarto.ShowDialog();
        }

        private void itemQuarto_Click(object sender, EventArgs e)
        {
            formQuarto telaQuarto = new formQuarto();
            telaQuarto.ShowDialog();
        }

        private void itemServico_Click(object sender, EventArgs e)
        {
            formServico telaServico = new formServico();
            telaServico.ShowDialog();
        }

        private void acessoServicos_Click(object sender, EventArgs e)
        {
            formServico telaServico = new formServico();
            telaServico.ShowDialog();
        }

        private void acessoFuncionarios_Click(object sender, EventArgs e)
        {
            formFuncionario telaFuncionario = new formFuncionario();
            telaFuncionario.ShowDialog();
        }

        private void itemFuncionario_Click(object sender, EventArgs e)
        {
            formFuncionario telaFuncionario = new formFuncionario();
            telaFuncionario.ShowDialog();
        }

        private void linkFuncionarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formFuncionario telaFuncionario = new formFuncionario();
            telaFuncionario.ShowDialog();
        }

        private void itemInformacoes_Click(object sender, EventArgs e)
        {
            formUsuario telaUsuario = new formUsuario(nomeFuncionario, cargoFuncionario, telefoneFuncionario, emailFuncionario, loginFuncionario, senhaFuncionario);
            telaUsuario.ShowDialog();
        }

        private void acessoVendas_Click(object sender, EventArgs e)
        {
            formVendas telaVendas = new formVendas();
            telaVendas.ShowDialog();
        }

        private void linkVendas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formVendas telaVendas = new formVendas();
            telaVendas.ShowDialog();
        }

        private void itemVenda_Click(object sender, EventArgs e)
        {
            formVendas telaVendas = new formVendas();
            telaVendas.ShowDialog();
        }

        private void acessoCheckOut_Click(object sender, EventArgs e)
        {
            formCheckOut telaCheckOut = new formCheckOut();
            telaCheckOut.ShowDialog();
        }

        private void linkCheckOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCheckOut telaCheckOut = new formCheckOut();
            telaCheckOut.ShowDialog();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCheckOut telaCheckOut = new formCheckOut();
            telaCheckOut.ShowDialog();
        }

        private void itemFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            exibirDataViewCheckIn();
            exibirDataViewCheckOut();
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            horaLogin.Text = datetime;
        }

        public void exibirDataViewCheckIn()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT idHospedagem, numeroQuarto, cpfHospede, checkIn, checkOut FROM TBhospedagem WHERE idHospedagem NOT IN (SELECT idHospedagem FROM TBcheckOut)", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewCheckIn.DataSource = dataTable;
        }
        public void exibirDataViewCheckOut()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TBcheckOut.idHospedagem, TBhospedagem.numeroQuarto, TBhospedagem.cpfHospede, TBcheckOut.valorTotal, TBhospedagem.checkIn, TBhospedagem.checkOut FROM TBcheckOut JOIN TBhospedagem ON TBcheckOut.idHospedagem=TBhospedagem.idHospedagem", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewCheckOut.DataSource = dataTable;
        }

        private void atualizarDataView_Click(object sender, EventArgs e)
        {
            exibirDataViewCheckIn();
            exibirDataViewCheckOut();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaAtual.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}

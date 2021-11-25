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
    public partial class formBuscarHospedagem : Form
    {
        public string idHospedagem { get; private set; }
        public string cpfHospede { get; private set; }
        public string quartoHospedagem { get; private set; }
        public string checkIn { get; private set; }
        public string checkOut { get; private set; }
        public string valorHospedagem { get; private set; }

        public formBuscarHospedagem()
        {
            InitializeComponent();
        }
        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TBhospedagem.idHospedagem,TBhospede.cpfHospede,TBhospede.nomeHospede, TBquarto.numeroQuarto,TBquarto.valorQuarto,TBhospedagem.checkIn,TBhospedagem.checkOut,TBhospedagem.valorHospedagem, TBhospedagem.acompanhantes FROM TBhospedagem JOIN TBhospede ON TBhospedagem.cpfHospede = TBhospede.cpfHospede JOIN TBquarto ON TBhospedagem.numeroQuarto = TBquarto.numeroQuarto WHERE idHospedagem NOT IN (SELECT idHospedagem FROM TBcheckOut)", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospedagem.DataSource = dataTable;
        }

        private void formBuscarHospedagem_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTidHospedagem.Enabled = false;
            TXTacompanhantes.Enabled = false;
            dataCheckIn.Enabled = false;
            dataCheckOut.Enabled = false;
            TXTnumeroQuarto.Enabled = false;
            TXTcpfHospede.Enabled = false;
            TXTvalorHospedagem.Enabled = false;
            TXTnomeHospede.Enabled = false;
            TXTvalorQuarto.Enabled = false;
        }

        private void TXTbuscarHospedagem_TextChanged(object sender, EventArgs e)
        {
            if (TXTbuscarHospedagem.Text == "")
            {
                exibirDataView();
            }
            else
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
                sql.Open();
                SqlCommand command = new SqlCommand("SELECT TBhospedagem.idHospedagem,TBhospede.cpfHospede,TBhospede.nomeHospede, TBquarto.numeroQuarto,TBquarto.valorQuarto,TBhospedagem.checkIn,TBhospedagem.checkOut,TBhospedagem.valorHospedagem, TBhospedagem.acompanhantes FROM TBhospedagem JOIN TBhospede ON TBhospedagem.cpfHospede = TBhospede.cpfHospede JOIN TBquarto ON TBhospedagem.numeroQuarto = TBquarto.numeroQuarto WHERE idHospedagem NOT IN (SELECT idHospedagem FROM TBcheckOut) AND idHospedagem like '" + TXTbuscarHospedagem.Text + "%' OR TBhospede.cpfHospede like '" + TXTbuscarHospedagem.Text + "%' OR TBhospede.nomeHospede like '" + TXTbuscarHospedagem.Text + "%'", sql);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataViewHospedagem.DataSource = dataTable;
                sql.Close();
            }
        }

        private void BTNhospedagemEscolhida_Click(object sender, EventArgs e)
        {
            this.idHospedagem = TXTidHospedagem.Text;
            this.cpfHospede = TXTcpfHospede.Text;
            this.quartoHospedagem = TXTnumeroQuarto.Text;
            this.checkIn = dataCheckIn.Text;
            this.checkOut = dataCheckOut.Text;
            this.valorHospedagem = TXTvalorHospedagem.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataViewHospedagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewHospedagem.Rows[e.RowIndex];
                TXTidHospedagem.Text = row.Cells[0].Value.ToString();
                TXTacompanhantes.Text = row.Cells[8].Value.ToString();
                dataCheckIn.Text = row.Cells[5].Value.ToString();
                dataCheckOut.Text = row.Cells[6].Value.ToString();
                TXTnumeroQuarto.Text = row.Cells[3].Value.ToString();
                TXTcpfHospede.Text = row.Cells[1].Value.ToString();
                TXTvalorHospedagem.Text = row.Cells[7].Value.ToString();
                TXTnomeHospede.Text = row.Cells[2].Value.ToString();
                TXTvalorQuarto.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo ID da Hospedagem, Pelo CPF ou NOME do Hóspede!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

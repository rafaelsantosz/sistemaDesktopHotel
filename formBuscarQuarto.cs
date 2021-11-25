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
    public partial class formBuscarQuarto : Form
    {
        public string numeroQuarto { get; private set; }
        public string valorQuarto { get; private set; }
        public string tipoQuarto { get; private set; }

        public formBuscarQuarto()
        {
            InitializeComponent();
        }
        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBquarto WHERE disponivel = 'S'", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewQuarto.DataSource = dataTable;
        }

        private void BTNquartoEscolhido_Click(object sender, EventArgs e)
        {
            this.numeroQuarto = TXTnumeroQuarto.Text;
            this.valorQuarto = TXTvalorQuarto.Text;
            this.tipoQuarto = comboTipoQuarto.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void formBuscarQuarto_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTnumeroQuarto.Enabled = false;
            comboTipoQuarto.Enabled = false;
            TXTvalorQuarto.Enabled = false;
            TXTdetalhesQuarto.Enabled = false;
            comboQuartoDisponivel.Enabled = false;
        }

        private void TXTbuscarQuarto_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBquarto WHERE disponivel = 'S' AND numeroQuarto like '" + TXTbuscarQuarto.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewQuarto.DataSource = dataTable;
            sql.Close();
        }

        private void dataViewQuarto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            DataGridViewRow row = dataViewQuarto.Rows[e.RowIndex];
            TXTnumeroQuarto.Text = row.Cells[0].Value.ToString();
            comboTipoQuarto.Text = row.Cells[1].Value.ToString();
            TXTvalorQuarto.Text = row.Cells[2].Value.ToString();
            comboQuartoDisponivel.Text = row.Cells[3].Value.ToString();
            TXTdetalhesQuarto.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo NÚMERO do Quarto!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

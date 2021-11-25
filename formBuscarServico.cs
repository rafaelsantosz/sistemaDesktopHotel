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
    public partial class formBuscarServico : Form
    {
        public string nomeServico { get; private set; }
        public string valorServico { get; private set; }

        public formBuscarServico()
        {
            InitializeComponent();
        }
        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBservico", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewServico.DataSource = dataTable;
        }

        private void dataViewServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewServico.Rows[e.RowIndex];
                TXTservico.Text = row.Cells[0].Value.ToString();
                comboTipoServico.Text = row.Cells[1].Value.ToString();
                TXTvalorServico.Text = row.Cells[2].Value.ToString();
                TXTdetalhesServico.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void formBuscarServico_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTservico.Enabled = false;
            comboTipoServico.Enabled = false;
            TXTvalorServico.Enabled = false;
            TXTdetalhesServico.Enabled = false;

        }

        private void TXTbuscarServico_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBservico WHERE nomeServico like '" + TXTbuscarServico.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewServico.DataSource = dataTable;
            sql.Close();
        }

        private void BTNservicoEscolhido_Click(object sender, EventArgs e)
        {
            this.nomeServico = TXTservico.Text;
            this.valorServico = TXTvalorServico.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo NOME do Serviço!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

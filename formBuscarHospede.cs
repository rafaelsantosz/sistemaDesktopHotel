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
    public partial class formBuscarHospede : Form
    {
        public string cpfHospede { get; private set; }
        public string nomeHospede { get; private set; }

        public formBuscarHospede()
        {
            InitializeComponent();
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBhospede", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospede.DataSource = dataTable;
        }

        private void formBuscarHospede_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTcpfHospede.Enabled = false;
            TXTnomeHospede.Enabled = false;
            TXTcelularHospede.Enabled = false;
            TXTrgHospede.Enabled = false;
            TXTemailHospede.Enabled = false;
            TXTenderecoHospede.Enabled = false;
            comboVipHospede.Enabled = false;
        }

        private void TXTbuscarHospede_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBhospede where cpfHospede like '" + TXTbuscarHospede.Text + "%' UNION SELECT * FROM TBhospede where nomeHospede like '" + TXTbuscarHospede.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospede.DataSource = dataTable;
            sql.Close();
        }

        private void dataViewHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            DataGridViewRow row = dataViewHospede.Rows[e.RowIndex];
            TXTcpfHospede.Text = row.Cells[0].Value.ToString();
            TXTnomeHospede.Text = row.Cells[1].Value.ToString();
            TXTcelularHospede.Text = row.Cells[2].Value.ToString();
            TXTrgHospede.Text = row.Cells[3].Value.ToString();
            TXTemailHospede.Text = row.Cells[4].Value.ToString();
            TXTenderecoHospede.Text = row.Cells[5].Value.ToString();
            comboVipHospede.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo CPF ou NOME do Hóspede!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BTNhospedeEscolhido_Click(object sender, EventArgs e)
        {
            this.cpfHospede = TXTcpfHospede.Text;
            this.nomeHospede = TXTnomeHospede.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

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
    public partial class formServico : Form
    {
        public formServico()
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

        private void BTNcadastrarServico_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBservico(nomeServico, tipoServico, valorServico, detalhesServico) values (@nomeServico, @tipoServico, @valorServico, @detalhesServico)", sql);
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTservico.Text;
            command.Parameters.Add("@tipoServico", SqlDbType.VarChar).Value = comboTipoServico.Text;
            command.Parameters.Add("@valorServico", SqlDbType.Float).Value = TXTvalorServico.Text;
            command.Parameters.Add("@detalhesServico", SqlDbType.VarChar).Value = TXTdetalhesServico.Text;

            if (TXTservico.Text != "" & comboTipoServico.Text != "" & TXTvalorServico.Text != "" & TXTdetalhesServico.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Serviço Cadastrado com Sucesso!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTservico.Text = "";
                    comboTipoServico.Text = "";
                    TXTvalorServico.Text = "";
                    TXTdetalhesServico.Text = "";
                    TXTbuscarServico.Text = "";
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Cadastrar o Serviço, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formServico_Load(object sender, EventArgs e)
        {
            exibirDataView();
        }

        private void BTNeditarServico_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBservico set nomeServico=@nomeServico, tipoServico=@tipoServico, valorServico=@valorServico, detalhesServico=@detalhesServico where nomeServico=@nomeServico", sql);
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTservico.Text;
            command.Parameters.Add("@tipoServico", SqlDbType.VarChar).Value = comboTipoServico.Text;
            command.Parameters.Add("@valorServico", SqlDbType.Float).Value = TXTvalorServico.Text;
            command.Parameters.Add("@detalhesServico", SqlDbType.VarChar).Value = TXTdetalhesServico.Text;

            if (TXTservico.Text != "" & comboTipoServico.Text != "" & TXTvalorServico.Text != "" & TXTdetalhesServico.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTservico.Text = "";
                    comboTipoServico.Text = "";
                    TXTvalorServico.Text = "";
                    TXTdetalhesServico.Text = "";
                    TXTbuscarServico.Text = "";
                    TXTservico.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Editar os Dados do Serviço, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirServico_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBservico WHERE nomeServico=@nomeServico", sql);
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTservico.Text;

            if (TXTservico.Text != "" & comboTipoServico.Text != "" & TXTvalorServico.Text != "" & TXTdetalhesServico.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir o Serviço?", "Hotel Transilvânia - Serviços", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Serviço Excluido com Sucesso!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTservico.Text = "";
                        comboTipoServico.Text = "";
                        TXTvalorServico.Text = "";
                        TXTdetalhesServico.Text = "";
                        TXTbuscarServico.Text = "";
                        TXTservico.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi Possível Excluir o Serviço, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCamposServico_Click(object sender, EventArgs e)
        {
            TXTservico.Text = "";
            comboTipoServico.Text = "";
            TXTvalorServico.Text = "";
            TXTdetalhesServico.Text = "";
            TXTbuscarServico.Text = "";
            TXTservico.Enabled = true;
            exibirDataView();
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

        private void dataViewServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewServico.Rows[e.RowIndex];
                TXTservico.Text = row.Cells[0].Value.ToString();
                comboTipoServico.Text = row.Cells[1].Value.ToString();
                TXTvalorServico.Text = row.Cells[2].Value.ToString();
                TXTdetalhesServico.Text = row.Cells[3].Value.ToString();
                TXTservico.Enabled = false;
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo NOME do Serviço!", "Hotel Transilvânia - Serviços", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

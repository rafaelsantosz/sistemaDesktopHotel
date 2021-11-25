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
    public partial class formQuarto : Form
    {
        public formQuarto()
        {
            InitializeComponent();
        }

        private void BTNcadastrarQuarto_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBquarto(numeroQuarto, tipoQuarto, valorQuarto, disponivel, detalhesQuarto) values (@numeroQuarto, @tipoQuarto, @valorQuarto, @disponivel, @detalhesQuarto)", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@tipoQuarto", SqlDbType.VarChar).Value = comboTipoQuarto.Text;
            command.Parameters.Add("@valorQuarto", SqlDbType.Float).Value = TXTvalorQuarto.Text;
            command.Parameters.Add("@disponivel", SqlDbType.VarChar).Value = comboQuartoDisponivel.Text;
            command.Parameters.Add("@detalhesQuarto", SqlDbType.VarChar).Value = TXTdetalhesQuarto.Text;

            if (TXTnumeroQuarto.Text != "" & comboTipoQuarto.Text != "" & TXTvalorQuarto.Text != "" & comboQuartoDisponivel.Text != "" & TXTdetalhesQuarto.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Quarto Cadastrado com Sucesso!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTnumeroQuarto.Text = "";
                    comboTipoQuarto.Text = "";
                    TXTvalorQuarto.Text = "";
                    comboQuartoDisponivel.Text = "";
                    TXTdetalhesQuarto.Text = "";
                    TXTbuscarQuarto.Text = "";
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Cadastrar o Quarto, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBquarto", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewQuarto.DataSource = dataTable;
        }

        private void formQuarto_Load(object sender, EventArgs e)
        {
            exibirDataView();
        }

        private void BTNeditarQuarto_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBquarto set numeroQuarto=@numeroQuarto, tipoQuarto=@tipoQuarto, valorQuarto=@valorQuarto, disponivel=@disponivel, detalhesQuarto=@detalhesQuarto where numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@tipoQuarto", SqlDbType.VarChar).Value = comboTipoQuarto.Text;
            command.Parameters.Add("@valorQuarto", SqlDbType.Float).Value = TXTvalorQuarto.Text;
            command.Parameters.Add("@disponivel", SqlDbType.VarChar).Value = comboQuartoDisponivel.Text;
            command.Parameters.Add("@detalhesQuarto", SqlDbType.VarChar).Value = TXTdetalhesQuarto.Text;

            if (TXTnumeroQuarto.Text != "" & comboTipoQuarto.Text != "" & TXTvalorQuarto.Text != "" & comboQuartoDisponivel.Text != "" & TXTdetalhesQuarto.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTnumeroQuarto.Text = "";
                    comboTipoQuarto.Text = "";
                    TXTvalorQuarto.Text = "";
                    comboQuartoDisponivel.Text = "";
                    TXTdetalhesQuarto.Text = "";
                    TXTbuscarQuarto.Text = "";
                    TXTnumeroQuarto.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Editar os Dados do Quarto, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirQuarto_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBquarto WHERE numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;

            if (TXTnumeroQuarto.Text != "" & comboTipoQuarto.Text != "" & TXTvalorQuarto.Text != "" & comboQuartoDisponivel.Text != "" & TXTdetalhesQuarto.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir o Quarto?", "Hotel Transilvânia - Quartos", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Quarto Excluido com Sucesso!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTnumeroQuarto.Text = "";
                        comboTipoQuarto.Text = "";
                        TXTvalorQuarto.Text = "";
                        comboQuartoDisponivel.Text = "";
                        TXTdetalhesQuarto.Text = "";
                        TXTbuscarQuarto.Text = "";
                        TXTnumeroQuarto.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi Possível Excluir o Quarto, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha todos os campos!", "Hotel Transilvânia - Quartos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCamposQuarto_Click(object sender, EventArgs e)
        {
            TXTnumeroQuarto.Text = "";
            comboTipoQuarto.Text = "";
            TXTvalorQuarto.Text = "";
            comboQuartoDisponivel.Text = "";
            TXTdetalhesQuarto.Text = "";
            TXTbuscarQuarto.Text = "";
            TXTnumeroQuarto.Enabled = true;
            exibirDataView();
        }

        private void TXTbuscarQuarto_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBquarto WHERE numeroQuarto like '" + TXTbuscarQuarto.Text + "%'", sql);
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
                TXTnumeroQuarto.Enabled = false;
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

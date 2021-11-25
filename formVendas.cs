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
    public partial class formVendas : Form
    {
        public formVendas()
        {
            InitializeComponent();
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TBvenda.idVenda, TBservico.nomeServico, TBservico.valorServico, TBvenda.quantidade, TBvenda.valorVenda, TBhospedageM.numeroQuarto, TBhospedagem.cpfHospede, TBhospedagem.idHospedagem FROM TBvenda JOIN TBservico ON TBvenda.nomeServico=TBservico.nomeServico JOIN TBhospedagem ON TBvenda.idHospedagem=TBhospedagem.idHospedagem", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewVenda.DataSource = dataTable;
        }

        private void formVendas_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTvalorServico.Enabled = false;
            TXTcpfHospede.Enabled = false;
            TXTnumeroQuarto.Enabled = false;
            TXTvalorTotal.Enabled = false;
            TXTnomeServico.Enabled = false;
            TXTidHospedagem.Enabled = false;
        }

        private void BTNcadastrarVenda_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBvenda(idVenda, nomeServico, quantidade, idHospedagem, valorVenda) values (@idVenda, @nomeServico, @quantidade, @idHospedagem, @valorVenda)", sql);
            command.Parameters.Add("@idVenda", SqlDbType.Int).Value = TXTidVenda.Text;
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTnomeServico.Text;
            command.Parameters.Add("@quantidade", SqlDbType.Int).Value = TXTquantidade.Text;
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;
            command.Parameters.Add("@valorVenda", SqlDbType.Float).Value = TXTvalorTotal.Text;

            if (TXTidVenda.Text != "" & TXTnomeServico.Text != "" & TXTvalorServico.Text !="" & TXTquantidade.Text != "" & TXTidHospedagem.Text != "" & TXTcpfHospede.Text != "" & TXTnumeroQuarto.Text != "" & TXTvalorTotal.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Venda Efetuada com Sucesso!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTidVenda.Text = "";
                    TXTnomeServico.Text = "";
                    TXTvalorServico.Text = "";
                    TXTquantidade.Text = "";
                    TXTidHospedagem.Text = "";
                    TXTcpfHospede.Text = "";
                    TXTnumeroQuarto.Text = "";
                    TXTvalorTotal.Text = "";
                    TXTbuscarVenda.Text = "";
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não Foi Realizar a Venda, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNeditarVenda_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBvenda set idVenda=@idVenda, nomeServico=@nomeServico, quantidade=@quantidade, idHospedagem=@idHospedagem, valorVenda=@valorVenda where idVenda=@idVenda", sql);
            command.Parameters.Add("@idVenda", SqlDbType.Int).Value = TXTidVenda.Text;
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTnomeServico.Text;
            command.Parameters.Add("@quantidade", SqlDbType.Int).Value = TXTquantidade.Text;
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidVenda.Text;
            command.Parameters.Add("@valorVenda", SqlDbType.Float).Value = TXTvalorTotal.Text;

            if (TXTidVenda.Text != "" & TXTnomeServico.Text != "" & TXTvalorServico.Text != "" & TXTquantidade.Text != "" & TXTidHospedagem.Text != "" & TXTcpfHospede.Text != "" & TXTnumeroQuarto.Text != "" & TXTvalorTotal.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTidVenda.Text = "";
                    TXTnomeServico.Text = "";
                    TXTvalorServico.Text = "";
                    TXTquantidade.Text = "";
                    TXTidHospedagem.Text = "";
                    TXTcpfHospede.Text = "";
                    TXTnumeroQuarto.Text = "";
                    TXTvalorTotal.Text = "";
                    TXTbuscarVenda.Text = "";
                    TXTidVenda.Enabled = true;
                    buscarHospedagem.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não Foi Possível Atualizar os Dados da Venda, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirVenda_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBvenda WHERE idVenda=@idVenda", sql);
            command.Parameters.Add("@idVenda", SqlDbType.Int).Value = TXTidVenda.Text;

            if (TXTidVenda.Text != "" & TXTnomeServico.Text != "" & TXTvalorServico.Text != "" & TXTquantidade.Text != "" & TXTidHospedagem.Text != "" & TXTcpfHospede.Text != "" & TXTnumeroQuarto.Text != "" & TXTvalorTotal.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir a Venda?", "Hotel Transilvânia - Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Venda Excluida com Sucesso!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTidVenda.Text = "";
                        TXTnomeServico.Text = "";
                        TXTvalorServico.Text = "";
                        TXTquantidade.Text = "";
                        TXTidHospedagem.Text = "";
                        TXTcpfHospede.Text = "";
                        TXTnumeroQuarto.Text = "";
                        TXTvalorTotal.Text = "";
                        TXTbuscarVenda.Text = "";
                        TXTidVenda.Enabled = true;
                        buscarHospedagem.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não Foi Possível Excluir a Venda!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha todos os campos!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCamposVenda_Click(object sender, EventArgs e)
        {
            TXTidVenda.Text = "";
            TXTnomeServico.Text = "";
            TXTvalorServico.Text = "";
            TXTquantidade.Text = "";
            TXTidHospedagem.Text = "";
            TXTcpfHospede.Text = "";
            TXTnumeroQuarto.Text = "";
            TXTvalorTotal.Text = "";
            TXTbuscarVenda.Text = "";
            TXTidVenda.Enabled = true;
            buscarHospedagem.Enabled = true;
            exibirDataView();
        }

        private void TXTbuscarVenda_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT TBvenda.idVenda, TBservico.nomeServico, TBservico.valorServico, TBvenda.quantidade, TBvenda.valorVenda, TBhospedageM.numeroQuarto, TBhospedagem.cpfHospede, TBhospedagem.idHospedagem FROM TBvenda JOIN TBservico ON TBvenda.nomeServico=TBservico.nomeServico JOIN TBhospedagem ON TBvenda.idHospedagem=TBhospedagem.idHospedagem WHERE idVenda like '" + TXTbuscarVenda.Text + "%' OR TBvenda.nomeServico like '" + TXTbuscarVenda.Text + "%' OR TBhospedagem.cpfHospede like '" + TXTbuscarVenda.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewVenda.DataSource = dataTable;
            sql.Close();
        }

        private void TXTquantidade_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("SELECT valorServico FROM TBservico WHERE nomeServico=@nomeServico", sql);
            command.Parameters.Add("@nomeServico", SqlDbType.VarChar).Value = TXTnomeServico.Text;

            try
            {
                sql.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                int precoServico = Convert.ToInt32(TXTvalorServico.Text);
                int quantidadeServico = Convert.ToInt32(TXTquantidade.Text);
                int valorTotal = precoServico*quantidadeServico;
                TXTvalorTotal.Text = Convert.ToString(valorTotal);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                sql.Close();
            }
        }

        private void dataViewVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewVenda.Rows[e.RowIndex];
                TXTidVenda.Text = row.Cells[0].Value.ToString();
                TXTnomeServico.Text = row.Cells[1].Value.ToString();
                TXTvalorServico.Text = row.Cells[2].Value.ToString();
                TXTquantidade.Text = row.Cells[3].Value.ToString();
                TXTidHospedagem.Text = row.Cells[7].Value.ToString();
                TXTcpfHospede.Text = row.Cells[6].Value.ToString();
                TXTnumeroQuarto.Text = row.Cells[5].Value.ToString();
                TXTvalorTotal.Text = row.Cells[4].Value.ToString();
                TXTidVenda.Enabled = false;
                buscarHospedagem.Enabled = false;
            }
            catch
            {

            }
        }

        private void buscarServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dadosServico = new formBuscarServico();
            if (dadosServico.ShowDialog() != DialogResult.OK)
                return;

            TXTnomeServico.Text = dadosServico.nomeServico;
            TXTvalorServico.Text = dadosServico.valorServico;
        }

        private void buscarHospedagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dadosHospedagem = new formBuscarHospedagem();
            if (dadosHospedagem.ShowDialog() != DialogResult.OK)
                return;

            TXTcpfHospede.Text = dadosHospedagem.cpfHospede;
            TXTnumeroQuarto.Text = dadosHospedagem.quartoHospedagem;
            TXTidHospedagem.Text = dadosHospedagem.idHospedagem;
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo ID da Venda, NOME do Serviço ou CPF do Hóspede!", "Hotel Transilvânia - Venda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

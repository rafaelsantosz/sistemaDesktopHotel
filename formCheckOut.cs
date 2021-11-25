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
    public partial class formCheckOut : Form
    {
        public formCheckOut()
        {
            InitializeComponent();
        }
        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TBcheckOut.idCheckOut, TBcheckOut.idHospedagem, TBhospedagem.numeroQuarto, TBhospedagem.cpfHospede, TBhospedagem.valorHospedagem, TBcheckOut.consumos, TBcheckOut.valorTotal, TBhospedagem.checkIn, TBhospedagem.checkOut FROM TBcheckOut JOIN TBhospedagem ON TBcheckOut.idHospedagem=TBhospedagem.idHospedagem", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewCheckOut.DataSource = dataTable;
        }

        private void formCheckOut_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTidHospedagem.Enabled = false;
            TXTcpfHospede.Enabled = false;
            TXTnumeroQuarto.Enabled = false;
            dataCheckIn.Enabled = false;
            dataCheckOut.Enabled = false;
            TXTvalorHospedagem.Enabled = false;
            TXTconsumos.Enabled = false;
            TXTvalorTotal.Enabled = false;
        }

        private void BTNexcluirCheckOut_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBcheckOut WHERE idCheckOut=@idCheckOut", sql);
            command.Parameters.Add("@idCheckOut", SqlDbType.Int).Value = TXTidCheckOut.Text;

            if (TXTidCheckOut.Text != "" & TXTidHospedagem.Text != "" & TXTcpfHospede.Text != "" & TXTnumeroQuarto.Text != "" & dataCheckIn.Text != "" & dataCheckOut.Text != "" & TXTvalorHospedagem.Text != "" & TXTconsumos.Text != "" & TXTvalorTotal.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir o Check-Out?", "Hotel Transilvânia - Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Check-Out Excluido com Sucesso!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTidCheckOut.Text = "";
                        TXTidHospedagem.Text = "";
                        TXTcpfHospede.Text = "";
                        TXTnumeroQuarto.Text = "";
                        dataCheckIn.Text = "";
                        dataCheckOut.Text = "";
                        TXTvalorHospedagem.Text = "";
                        TXTconsumos.Text = "";
                        TXTvalorTotal.Text = "";
                        TXTbuscarCheckOut.Text = "";
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi Possível Excluir o Check-Out, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buscarHospedagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dadosHospedagem = new formBuscarHospedagem();
            if (dadosHospedagem.ShowDialog() != DialogResult.OK)
                return;

            TXTcpfHospede.Text = dadosHospedagem.cpfHospede;
            TXTnumeroQuarto.Text = dadosHospedagem.quartoHospedagem;
            TXTidHospedagem.Text = dadosHospedagem.idHospedagem;
            dataCheckIn.Text = dadosHospedagem.checkIn;
            dataCheckOut.Text = dadosHospedagem.checkOut;
            TXTvalorHospedagem.Text = dadosHospedagem.valorHospedagem;
            valorConsumos();
        }

        private void BTNcadastrarCheckOut_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBcheckOut(idCheckOut, idHospedagem, consumos, valorTotal) values (@idCheckOut, @idHospedagem, @consumos, @valorTotal)", sql);
            command.Parameters.Add("@idCheckOut", SqlDbType.Int).Value = TXTidCheckOut.Text;
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;
            command.Parameters.Add("@consumos", SqlDbType.Float).Value = TXTconsumos.Text;
            command.Parameters.Add("@valorTotal", SqlDbType.Float).Value = TXTvalorTotal.Text;

            if (TXTidCheckOut.Text != "" & TXTidHospedagem.Text != "" & TXTcpfHospede.Text != "" & TXTnumeroQuarto.Text != "" & dataCheckIn.Text != "" & dataCheckOut.Text != "" & TXTvalorHospedagem.Text != "" & TXTconsumos.Text != "" & TXTvalorTotal.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Check-Out Feito com Sucesso!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarQuartoDisponivel();
                    TXTidCheckOut.Text = "";
                    TXTidHospedagem.Text = "";
                    TXTcpfHospede.Text = "";
                    TXTnumeroQuarto.Text = "";
                    dataCheckIn.Text = "";
                    dataCheckOut.Text = "";
                    TXTvalorHospedagem.Text = "";
                    TXTconsumos.Text = "";
                    TXTvalorTotal.Text = "";
                    TXTbuscarCheckOut.Text = "";
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Realizar o Check-Out, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTbuscarCheckOut_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT TBcheckOut.idCheckOut, TBcheckOut.idHospedagem, TBhospedagem.numeroQuarto, TBhospedagem.cpfHospede, TBhospedagem.valorHospedagem, TBcheckOut.consumos, TBcheckOut.valorTotal, TBhospedagem.checkIn, TBhospedagem.checkOut FROM TBcheckOut JOIN TBhospedagem ON TBcheckOut.idHospedagem=TBhospedagem.idHospedagem WHERE idCheckOut like '" + TXTbuscarCheckOut.Text + "%' OR TBhospedagem.cpfHospede like '" + TXTbuscarCheckOut.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewCheckOut.DataSource = dataTable;
            sql.Close();
        }

        private void dataViewCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewCheckOut.Rows[e.RowIndex];
                TXTidCheckOut.Text = row.Cells[0].Value.ToString();
                TXTidHospedagem.Text = row.Cells[1].Value.ToString();
                TXTcpfHospede.Text = row.Cells[3].Value.ToString();
                TXTnumeroQuarto.Text = row.Cells[2].Value.ToString();
                dataCheckIn.Text = row.Cells[7].Value.ToString();
                dataCheckOut.Text = row.Cells[8].Value.ToString();
                TXTvalorHospedagem.Text = row.Cells[4].Value.ToString();
                TXTconsumos.Text = row.Cells[5].Value.ToString();
                TXTvalorTotal.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void limparCamposCheckOut_Click(object sender, EventArgs e)
        {
            TXTidCheckOut.Text = "";
            TXTidHospedagem.Text = "";
            TXTcpfHospede.Text = "";
            TXTnumeroQuarto.Text = "";
            dataCheckIn.Text = "";
            dataCheckOut.Text = "";
            TXTvalorHospedagem.Text = "";
            TXTconsumos.Text = "";
            TXTvalorTotal.Text = "";
            TXTbuscarCheckOut.Text = "";
            exibirDataView();
        }

        private void valorConsumos()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("SELECT SUM(valorVenda) AS valorConsumo FROM TBvenda WHERE idHospedagem=@idHospedagem", sql);
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;

            try
            {
                sql.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                int precoHospedagem = Convert.ToInt32(TXTvalorHospedagem.Text);
                TXTconsumos.Text = Convert.ToString(dataReader["valorConsumo"]);
                if (TXTconsumos.Text == "")
                    TXTconsumos.Text = "0";
                int valorConsumo = Convert.ToInt32(TXTconsumos.Text);
                int valorTotal = precoHospedagem + valorConsumo;
                TXTvalorTotal.Text = Convert.ToString(valorTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo ID do Check-Out ou CPF do Hóspede!", "Hotel Transilvânia - Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void atualizarQuartoDisponivel()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBquarto set numeroQuarto=@numeroQuarto, disponivel=@disponivel where numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@disponivel", SqlDbType.VarChar).Value = 'S';

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}

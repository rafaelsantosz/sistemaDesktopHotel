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
    public partial class formHospedagem : Form
    {
        string tipo = "";

        public formHospedagem()
        {
            InitializeComponent();
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TBhospedagem.idHospedagem,TBhospede.cpfHospede,TBhospede.nomeHospede, TBquarto.numeroQuarto,TBquarto.valorQuarto,TBhospedagem.checkIn,TBhospedagem.checkOut,TBhospedagem.valorHospedagem, TBhospedagem.acompanhantes FROM TBhospedagem JOIN TBhospede ON TBhospedagem.cpfHospede = TBhospede.cpfHospede JOIN TBquarto ON TBhospedagem.numeroQuarto = TBquarto.numeroQuarto", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospedagem.DataSource = dataTable;
        }

        private void BTNcadastrarHospedagem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBhospedagem(idHospedagem, acompanhantes, checkIn, checkOut, numeroQuarto, cpfHospede, valorHospedagem) values (@idHospedagem, @acompanhantes, @checkIn, @checkOut, @numeroQuarto, @cpfHospede, @valorHospedagem)", sql);
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;
            command.Parameters.Add("@acompanhantes", SqlDbType.Int).Value = TXTacompanhantes.Text;
            command.Parameters.Add("@checkIn", SqlDbType.Date).Value = dataCheckIn.Text;
            command.Parameters.Add("@checkOut", SqlDbType.Date).Value = dataCheckOut.Text;
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@cpfHospede", SqlDbType.VarChar).Value = TXTcpfHospede.Text;
            command.Parameters.Add("@valorHospedagem", SqlDbType.Float).Value = TXTvalorHospedagem.Text;

            if (TXTidHospedagem.Text != "" & TXTacompanhantes.Text != "" & dataCheckIn.Text != "" & dataCheckOut.Text != "" & TXTnumeroQuarto.Text != "" & TXTcpfHospede.Text != "" & TXTvalorHospedagem.Text != "" & TXTnomeHospede.Text != "" & TXTvalorQuarto.Text != "")
            {
                int hospedesAdc = Convert.ToInt32(TXTacompanhantes.Text);
                if (tipo == "Simples" & hospedesAdc > 0)
                {
                    MessageBox.Show("Número de Hóspedes Acima do Permitido! (Quarto Simples Comporta 1 Pessoa)", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tipo == "Duplo" & hospedesAdc > 1)
                {
                    MessageBox.Show("Número de Hóspedes Acima do Permitido! (Quarto Duplo Comporta Até 2 Pessoas)", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tipo == "Triplo" & hospedesAdc > 2)
                {
                    MessageBox.Show("Número de Hóspedes Acima do Permitido! (Quarto Triplo Comporta Até 3 Pessoas)", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tipo == "Deluxe" & hospedesAdc > 3)
                {
                    MessageBox.Show("Número de Hóspedes Acima do Permitido! (Quarto Deluxe Comporta Até 4 Pessoas)", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Hospedagem Feita com Sucesso!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizarQuartoDisponivel();
                        TXTidHospedagem.Text = "";
                        TXTacompanhantes.Text = "";
                        dataCheckIn.Text = "";
                        dataCheckOut.Text = "";
                        TXTnumeroQuarto.Text = "";
                        TXTcpfHospede.Text = "";
                        TXTvalorHospedagem.Text = "";
                        TXTnomeHospede.Text = "";
                        TXTvalorQuarto.Text = "";
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não Foi Possível Realizar a Hospedagem, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);;
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formHospedagem_Load(object sender, EventArgs e)
        {
            exibirDataView();
            TXTcpfHospede.Enabled = false;
            TXTnomeHospede.Enabled = false;
            TXTnumeroQuarto.Enabled = false;
            TXTvalorQuarto.Enabled = false;
            TXTvalorHospedagem.Enabled = false;

        }

        private void BTNeditarHospedagem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBhospedagem set idHospedagem=@idHospedagem, acompanhantes=@acompanhantes, checkIn=@checkIn, checkOut=@checkOut, numeroQuarto=@numeroQuarto, cpfHospede=@cpfHospede, valorHospedagem=@valorHospedagem where idHospedagem=@idHospedagem", sql);
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;
            command.Parameters.Add("@acompanhantes", SqlDbType.Int).Value = TXTacompanhantes.Text;
            command.Parameters.Add("@checkIn", SqlDbType.Date).Value = dataCheckIn.Text;
            command.Parameters.Add("@checkOut", SqlDbType.Date).Value = dataCheckOut.Text;
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@cpfHospede", SqlDbType.VarChar).Value = TXTcpfHospede.Text;
            command.Parameters.Add("@valorHospedagem", SqlDbType.Float).Value = TXTvalorHospedagem.Text;

            if (TXTidHospedagem.Text != "" & TXTacompanhantes.Text != "" & dataCheckIn.Text != "" & dataCheckOut.Text != "" & TXTnumeroQuarto.Text != "" & TXTcpfHospede.Text != "" & TXTvalorHospedagem.Text != "" & TXTnomeHospede.Text != "" & TXTvalorQuarto.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTidHospedagem.Text = "";
                    TXTacompanhantes.Text = "";
                    dataCheckIn.Text = "";
                    dataCheckOut.Text = "";
                    TXTnumeroQuarto.Text = "";
                    TXTcpfHospede.Text = "";
                    TXTvalorHospedagem.Text = "";
                    TXTbuscarHospedagem.Text = "";
                    TXTnomeHospede.Text = "";
                    TXTvalorQuarto.Text = "";
                    TXTidHospedagem.Enabled = true;
                    TXTacompanhantes.Enabled = true;
                    buscarHospede.Enabled = true;
                    buscarQuarto.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não Foi Possível Atualizar os Dados da Hospedagem, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirHospedagem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBhospedagem WHERE idHospedagem=@idHospedagem", sql);
            command.Parameters.Add("@idHospedagem", SqlDbType.Int).Value = TXTidHospedagem.Text;

            if (TXTidHospedagem.Text != "" & TXTacompanhantes.Text != "" & dataCheckIn.Text != "" & dataCheckOut.Text != "" & TXTnumeroQuarto.Text != "" & TXTcpfHospede.Text != "" & TXTvalorHospedagem.Text != "" & TXTnomeHospede.Text != "" & TXTvalorQuarto.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir a Hospedagem?", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Hospedagem Excluida com Sucesso!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTidHospedagem.Text = "";
                        TXTacompanhantes.Text = "";
                        dataCheckIn.Text = "";
                        dataCheckOut.Text = "";
                        TXTnumeroQuarto.Text = "";
                        TXTcpfHospede.Text = "";
                        TXTvalorHospedagem.Text = "";
                        TXTbuscarHospedagem.Text = "";
                        TXTnomeHospede.Text = "";
                        TXTvalorQuarto.Text = "";
                        TXTidHospedagem.Enabled = true;
                        TXTacompanhantes.Enabled = true;
                        buscarHospede.Enabled = true;
                        buscarQuarto.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não Foi Possível Excluir a Hospedagem, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha todos os campos!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCamposHospedagem_Click(object sender, EventArgs e)
        {
            TXTidHospedagem.Text = "";
            TXTacompanhantes.Text = "";
            dataCheckIn.Text = "";
            dataCheckOut.Text = "";
            TXTnumeroQuarto.Text = "";
            TXTcpfHospede.Text = "";
            TXTvalorHospedagem.Text = "";
            TXTbuscarHospedagem.Text = "";
            TXTnomeHospede.Text = "";
            TXTvalorQuarto.Text = "";
            TXTidHospedagem.Enabled = true;
            TXTacompanhantes.Enabled = true;
            buscarHospede.Enabled = true;
            buscarQuarto.Enabled = true;
            exibirDataView();
        }

        private void TXTbuscarHospedagem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT TBhospedagem.idHospedagem,TBhospede.cpfHospede,TBhospede.nomeHospede, TBquarto.numeroQuarto,TBquarto.valorQuarto,TBhospedagem.checkIn,TBhospedagem.checkOut,TBhospedagem.valorHospedagem, TBhospedagem.acompanhantes FROM TBhospedagem JOIN TBhospede ON TBhospedagem.cpfHospede = TBhospede.cpfHospede JOIN TBquarto ON TBhospedagem.numeroQuarto = TBquarto.numeroQuarto WHERE idHospedagem like '" + TXTbuscarHospedagem.Text + "%' OR TBhospede.cpfHospede like '" + TXTbuscarHospedagem.Text + "%' OR TBhospede.nomeHospede like '" + TXTbuscarHospedagem.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospedagem.DataSource = dataTable;
            sql.Close();
        }


        private void dataCheckOut_CloseUp(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("SELECT valorQuarto FROM TBquarto WHERE numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;

            try
            {
                sql.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                int precoQuarto = Convert.ToInt32(TXTvalorQuarto.Text);
                var dataEntrada = dataCheckIn.Text;
                var dataSaida = dataCheckOut.Text;

                TimeSpan date = Convert.ToDateTime(dataSaida) - Convert.ToDateTime(dataEntrada);
                int totalDias = date.Days;

                int valorTotal = precoQuarto * totalDias;
                TXTvalorHospedagem.Text = Convert.ToString(valorTotal);

            }
            catch (Exception)
            {

            }
            finally
            {
                sql.Close();
            }
        }

        private void dataCheckIn_CloseUp(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("SELECT valorQuarto FROM TBquarto WHERE numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;

            try
            {
                sql.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows == false)
                {
                    throw new Exception("Quarto não encontrado!");
                }

                dataReader.Read();
                int precoQuarto = Convert.ToInt32(TXTvalorQuarto.Text);
                var dataEntrada = dataCheckIn.Text;
                var dataSaida = dataCheckOut.Text;

                TimeSpan date = Convert.ToDateTime(dataSaida) - Convert.ToDateTime(dataEntrada);
                int totalDias = date.Days;

                int valorTotal = precoQuarto * totalDias;
                TXTvalorHospedagem.Text = Convert.ToString(valorTotal);

            }
            catch (Exception)
            {

            }
            finally
            {
                sql.Close();
            }
        }

        private void buscarHospede_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dadosHospede = new formBuscarHospede();
            if (dadosHospede.ShowDialog() != DialogResult.OK)
                return;

            TXTcpfHospede.Text = dadosHospede.cpfHospede;
            TXTnomeHospede.Text = dadosHospede.nomeHospede;
        }

        private void buscarQuarto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dadosQuarto = new formBuscarQuarto();
            if (dadosQuarto.ShowDialog() != DialogResult.OK)
                return;

            TXTnumeroQuarto.Text = dadosQuarto.numeroQuarto;
            TXTvalorQuarto.Text = dadosQuarto.valorQuarto;
            tipo = dadosQuarto.tipoQuarto;
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
                TXTidHospedagem.Enabled = false;
                TXTacompanhantes.Enabled = false;
                buscarHospede.Enabled = false;
                buscarQuarto.Enabled = false;
            }
            catch
            { 
            
            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo ID da Hospedagem, Pelo CPF ou NOME do Hóspede!", "Hotel Transilvânia - Hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void atualizarQuartoDisponivel()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBquarto set numeroQuarto=@numeroQuarto, disponivel=@disponivel where numeroQuarto=@numeroQuarto", sql);
            command.Parameters.Add("@numeroQuarto", SqlDbType.Int).Value = TXTnumeroQuarto.Text;
            command.Parameters.Add("@disponivel", SqlDbType.VarChar).Value = 'N';

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

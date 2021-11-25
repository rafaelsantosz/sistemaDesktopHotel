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
    public partial class formHospede : Form
    {
        public formHospede()
        {
            InitializeComponent();
        }

        private void BTNcadastrarHospede_Click(object sender, EventArgs e)
        {
            string senhaGerada = "";
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random caractereAleatorio = new Random();

            while (senhaGerada.Length < 6)
                senhaGerada += caracteres[caractereAleatorio.Next(caracteres.Length)];

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBhospede(cpfHospede, nomeHospede, telefoneHospede, RG,  emailHospede, enderecoHospede, VIP, senhaHospede) values (@cpfHospede, @nomeHospede, @telefoneHospede, @RG, @emailHospede, @enderecoHospede, @VIP, @senhaHospede)", sql);
            command.Parameters.Add("@cpfHospede", SqlDbType.VarChar).Value = TXTcpfHospede.Text;
            command.Parameters.Add("@nomeHospede", SqlDbType.VarChar).Value = TXTnomeHospede.Text;
            command.Parameters.Add("@telefoneHospede", SqlDbType.VarChar).Value = TXTcelularHospede.Text;
            command.Parameters.Add("@RG", SqlDbType.VarChar).Value = TXTrgHospede.Text;
            command.Parameters.Add("@emailHospede", SqlDbType.VarChar).Value = TXTemailHospede.Text;
            command.Parameters.Add("@enderecoHospede", SqlDbType.VarChar).Value = TXTenderecoHospede.Text;
            command.Parameters.Add("@VIP", SqlDbType.VarChar).Value = comboVipHospede.Text;
            command.Parameters.Add("@senhaHospede", SqlDbType.VarChar).Value = senhaGerada;

            if (TXTcpfHospede.Text != "" & TXTnomeHospede.Text != "" & TXTcelularHospede.Text != "" & TXTrgHospede.Text != "" & TXTemailHospede.Text != "" & TXTenderecoHospede.Text != "" & comboVipHospede.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Hóspede Cadastrado com Sucesso!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTcpfHospede.Text = "";
                    TXTnomeHospede.Text = "";
                    TXTcelularHospede.Text = "";
                    TXTrgHospede.Text = "";
                    TXTemailHospede.Text = "";
                    TXTenderecoHospede.Text = "";
                    comboVipHospede.Text = "";
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Cadastrar o Hóspede, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNeditarHospede_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBhospede set cpfHospede=@cpfHospede, nomeHospede=@nomeHospede, telefoneHospede=@telefoneHospede, RG=@RG, emailHospede=@emailHospede, enderecoHospede=@enderecoHospede, VIP=@VIP where cpfHospede=@cpfHospede", sql);
            command.Parameters.Add("@cpfHospede", SqlDbType.VarChar).Value = TXTcpfHospede.Text;
            command.Parameters.Add("@nomeHospede", SqlDbType.VarChar).Value = TXTnomeHospede.Text;
            command.Parameters.Add("@telefoneHospede", SqlDbType.VarChar).Value = TXTcelularHospede.Text;
            command.Parameters.Add("@RG", SqlDbType.VarChar).Value = TXTrgHospede.Text;
            command.Parameters.Add("@emailHospede", SqlDbType.VarChar).Value = TXTemailHospede.Text;
            command.Parameters.Add("@enderecoHospede", SqlDbType.VarChar).Value = TXTenderecoHospede.Text;
            command.Parameters.Add("@VIP", SqlDbType.VarChar).Value = comboVipHospede.Text;

            if (TXTcpfHospede.Text != "" & TXTnomeHospede.Text != "" & TXTcelularHospede.Text != "" & TXTrgHospede.Text != "" & TXTemailHospede.Text != "" & TXTenderecoHospede.Text != "" & comboVipHospede.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTcpfHospede.Text = "";
                    TXTnomeHospede.Text = "";
                    TXTcelularHospede.Text = "";
                    TXTrgHospede.Text = "";
                    TXTemailHospede.Text = "";
                    TXTenderecoHospede.Text = "";
                    comboVipHospede.Text = "";
                    TXTbuscarHospede.Text = "";
                    TXTcpfHospede.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possível Editar os Dados do Hóspede, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirHospede_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBhospede WHERE cpfHospede=@cpfHospede", sql);
            command.Parameters.Add("@cpfHospede", SqlDbType.VarChar).Value = TXTcpfHospede.Text;

            if (TXTcpfHospede.Text != "" & TXTnomeHospede.Text != "" & TXTcelularHospede.Text != "" & TXTrgHospede.Text != "" & TXTemailHospede.Text != "" & TXTenderecoHospede.Text != "" & comboVipHospede.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir o Hóspede?", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados do Hóspede Excluidos com Sucesso!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTcpfHospede.Text = "";
                        TXTnomeHospede.Text = "";
                        TXTcelularHospede.Text = "";
                        TXTrgHospede.Text = "";
                        TXTemailHospede.Text = "";
                        TXTenderecoHospede.Text = "";
                        comboVipHospede.Text = "";
                        TXTbuscarHospede.Text = "";
                        TXTcpfHospede.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi Possível Excluir o Hóspede, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCamposHospede_Click(object sender, EventArgs e)
        {
            TXTcpfHospede.Text = "";
            TXTnomeHospede.Text = "";
            TXTcelularHospede.Text = "";
            TXTrgHospede.Text = "";
            TXTemailHospede.Text = "";
            TXTenderecoHospede.Text = "";
            comboVipHospede.Text = "";
            TXTbuscarHospede.Text = "";
            TXTcpfHospede.Enabled = true;
            exibirDataView();
        }

        private void formHospede_Load(object sender, EventArgs e)
        {
            exibirDataView();
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBhospede", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewHospede.DataSource = dataTable;
        }

        private void TXTbuscarHospede_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBhospede where cpfHospede like '"+ TXTbuscarHospede.Text + "%' UNION SELECT * FROM TBhospede where nomeHospede like '" + TXTbuscarHospede.Text + "%'", sql);
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
                TXTcpfHospede.Enabled = false;
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo CPF ou NOME do Hóspede!", "Hotel Transilvânia - Hóspedes", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

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
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
        }

        private void BTNcadastrarFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("INSERT INTO TBfuncionario(cpfFuncionario, nomeFuncionario, cargo, salario, telefoneFuncionario, emailFuncionario, loginFuncionario, senhaFuncionario) values (@cpfFuncionario, @nomeFuncionario, @cargo, @salario, @telefoneFuncionario, @emailFuncionario, @loginFuncionario, @senhaFuncionario)", sql);
            command.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = TXTcpfFuncionario.Text;
            command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = TXTnomeFuncionario.Text;
            command.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargoFuncionario.Text;
            command.Parameters.Add("@salario", SqlDbType.Float).Value = TXTsalarioFuncionario.Text;
            command.Parameters.Add("@telefoneFuncionario", SqlDbType.VarChar).Value = TXTcelularFuncionario.Text;
            command.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = TXTemailFuncionario.Text;
            command.Parameters.Add("@loginFuncionario", SqlDbType.VarChar).Value = TXTloginFuncionario.Text;
            command.Parameters.Add("@senhaFuncionario", SqlDbType.VarChar).Value = TXTsenhaFuncionario.Text;
        
            if(TXTcpfFuncionario.Text!="" & TXTnomeFuncionario.Text != "" & comboCargoFuncionario.Text != "" & TXTsalarioFuncionario.Text != "" & TXTcelularFuncionario.Text != "" & TXTemailFuncionario.Text != "" & TXTloginFuncionario.Text != "" & TXTsenhaFuncionario.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTcpfFuncionario.Text = "";
                    TXTnomeFuncionario.Text = "";
                    comboCargoFuncionario.Text = "";
                    TXTsalarioFuncionario.Text = "";
                    TXTcelularFuncionario.Text = "";
                    TXTemailFuncionario.Text = "";
                    TXTloginFuncionario.Text = "";
                    TXTsenhaFuncionario.Text = "";
                    exibirDataView();
                }
                catch(Exception)
                {
                    MessageBox.Show("Não foi Possível Cadastrar o Funcionário, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formFuncionario_Load(object sender, EventArgs e)
        {
            exibirDataView();
        }

        private void limparCamposFuncionario_Click(object sender, EventArgs e)
        {
            TXTnomeFuncionario.Text = "";
            TXTcpfFuncionario.Text = "";
            TXTcelularFuncionario.Text = "";
            TXTemailFuncionario.Text = "";
            comboCargoFuncionario.Text = "";
            TXTsalarioFuncionario.Text = "";
            TXTloginFuncionario.Text = "";
            TXTsenhaFuncionario.Text = "";
            TXTbuscarFuncionario.Text = "";
            TXTcpfFuncionario.Enabled = true;
            exibirDataView();
        }

        private void BTNeditarFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("UPDATE TBfuncionario set cpfFuncionario=@cpfFuncionario, nomeFuncionario=@nomeFuncionario, cargo=@cargo, salario=@salario, telefoneFuncionario=@telefoneFuncionario, emailFuncionario=@emailFuncionario, loginFuncionario=@loginFuncionario, senhaFuncionario=@senhaFuncionario where cpfFuncionario=@cpfFuncionario", sql);
            command.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = TXTcpfFuncionario.Text;
            command.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = TXTnomeFuncionario.Text;
            command.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargoFuncionario.Text;
            command.Parameters.Add("@salario", SqlDbType.Float).Value = TXTsalarioFuncionario.Text;
            command.Parameters.Add("@telefoneFuncionario", SqlDbType.VarChar).Value = TXTcelularFuncionario.Text;
            command.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = TXTemailFuncionario.Text;
            command.Parameters.Add("@loginFuncionario", SqlDbType.VarChar).Value = TXTloginFuncionario.Text;
            command.Parameters.Add("@senhaFuncionario", SqlDbType.VarChar).Value = TXTsenhaFuncionario.Text;

            if (TXTcpfFuncionario.Text != "" & TXTnomeFuncionario.Text != "" & comboCargoFuncionario.Text != "" & TXTsalarioFuncionario.Text != "" & TXTcelularFuncionario.Text != "" & TXTemailFuncionario.Text != "" & TXTloginFuncionario.Text != "" & TXTsenhaFuncionario.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTcpfFuncionario.Text = "";
                    TXTnomeFuncionario.Text = "";
                    comboCargoFuncionario.Text = "";
                    TXTsalarioFuncionario.Text = "";
                    TXTcelularFuncionario.Text = "";
                    TXTemailFuncionario.Text = "";
                    TXTloginFuncionario.Text = "";
                    TXTsenhaFuncionario.Text = "";
                    TXTcpfFuncionario.Enabled = true;
                    exibirDataView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi Possivel Editar os Dados do Funcionário, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha Todos os Campos!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNexcluirFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("DELETE FROM TBfuncionario WHERE cpfFuncionario=@cpfFuncionario", sql);
            command.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = TXTcpfFuncionario.Text;

            if (TXTcpfFuncionario.Text != "" & TXTnomeFuncionario.Text != "" & comboCargoFuncionario.Text != "" & TXTsalarioFuncionario.Text != "" & TXTcelularFuncionario.Text != "" & TXTemailFuncionario.Text != "" & TXTloginFuncionario.Text != "" & TXTsenhaFuncionario.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem Certeza que Deseja Excluir o Funcionário?", "Hotel Transilvânia - Funcionários", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados do Funcionário Excluido com Sucesso!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXTcpfFuncionario.Text = "";
                        TXTnomeFuncionario.Text = "";
                        comboCargoFuncionario.Text = "";
                        TXTsalarioFuncionario.Text = "";
                        TXTcelularFuncionario.Text = "";
                        TXTemailFuncionario.Text = "";
                        TXTloginFuncionario.Text = "";
                        TXTsenhaFuncionario.Text = "";
                        TXTbuscarFuncionario.Text = "";
                        TXTcpfFuncionario.Enabled = true;
                        exibirDataView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi Possivel Excluir o Funcionário, Verifique os Dados e Tente Novamente!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor, Preencha todos os campos!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void exibirDataView()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBfuncionario", sql);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewFuncionario.DataSource = dataTable;
        }

        private void TXTbuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            sql.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBfuncionario where cpfFuncionario like '" + TXTbuscarFuncionario.Text + "%' OR nomeFuncionario like '" + TXTbuscarFuncionario.Text + "%'", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataViewFuncionario.DataSource = dataTable;
            sql.Close();
        }

        private void dataViewFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataViewFuncionario.Rows[e.RowIndex];
                TXTcpfFuncionario.Text = row.Cells[0].Value.ToString();
                TXTnomeFuncionario.Text = row.Cells[1].Value.ToString();
                comboCargoFuncionario.Text = row.Cells[2].Value.ToString();
                TXTsalarioFuncionario.Text = row.Cells[3].Value.ToString();
                TXTcelularFuncionario.Text = row.Cells[4].Value.ToString();
                TXTemailFuncionario.Text = row.Cells[5].Value.ToString();
                TXTloginFuncionario.Text = row.Cells[6].Value.ToString();
                TXTsenhaFuncionario.Text = row.Cells[7].Value.ToString();
                TXTcpfFuncionario.Enabled = false;
            }
            catch
            {

            }
        }

        private void ajudaBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busque Pelo CPF ou NOME do Funcionário!", "Hotel Transilvânia - Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

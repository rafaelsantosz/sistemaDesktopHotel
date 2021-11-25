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
    public partial class FormLogin : Form
    {
        public string nome { get; set; }
        public string cargo { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BTNentrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDhotelTransilvania;Data Source=DESKTOP-1TKTT32\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("SELECT * FROM TBfuncionario WHERE loginFuncionario=@loginFuncionario and senhaFuncionario=@senhaFuncionario", sql);
            command.Parameters.Add("@loginFuncionario", SqlDbType.VarChar).Value = TXTusuarioLogin.Text;
            command.Parameters.Add("@senhaFuncionario", SqlDbType.VarChar).Value = TXTsenhaLogin.Text;

            try
            {
                sql.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows == false)
                {
                    MessageBox.Show("Usuário ou Senha Incorreta!", "Hotel Transilvânia - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login Feito com Sucesso! Seja Bem-Vindo", "Hotel Transilvânia - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nome = Convert.ToString(dataReader["nomeFuncionario"]);
                    cargo = Convert.ToString(dataReader["cargo"]);
                    telefone = Convert.ToString(dataReader["telefoneFuncionario"]);
                    email = Convert.ToString(dataReader["emailFuncionario"]);
                    login = Convert.ToString(dataReader["loginFuncionario"]);
                    senha = Convert.ToString(dataReader["senhaFuncionario"]);

                    formMenuPrincipal menuPrincipal = new formMenuPrincipal(nome, cargo, telefone, email, login, senha);
                    menuPrincipal.ShowDialog();
                    this.Close();
                }
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
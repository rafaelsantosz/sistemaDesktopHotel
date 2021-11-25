using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransilvania
{
    public partial class formUsuario : Form
    {
        public formUsuario(string nomeFuncionario, string cargoFuncionario, string telefoneFuncionario, string emailFuncionario, string loginFuncionario, string senhaFuncionario)
        {
            InitializeComponent();
            TXTnomeFuncionario.Text = nomeFuncionario;
            TXTcargoFuncionario.Text = cargoFuncionario;
            TXTcelularFuncionario.Text = telefoneFuncionario;
            TXTemailFuncionario.Text = emailFuncionario;
            TXTloginFuncionario.Text = loginFuncionario;
            TXTsenhaFuncionario.Text = senhaFuncionario;
        }

        private void formUsuario_Load(object sender, EventArgs e)
        {
            TXTnomeFuncionario.Enabled = false;
            TXTcargoFuncionario.Enabled = false;
            TXTcelularFuncionario.Enabled = false;
            TXTemailFuncionario.Enabled = false;
            TXTloginFuncionario.Enabled = false;
            TXTsenhaFuncionario.Enabled = false;
        }
    }
}

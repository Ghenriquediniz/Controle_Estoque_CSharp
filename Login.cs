using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_G_
{
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = "adm";
            string senha = "adm";

            string usuarioDigitado = txt_usuario.Text;
            string senhaDigitada = txt_senha.Text;


            if (usuarioDigitado == usuario && senhaDigitada == senha)
            {
                this.Hide();
                var Frm_main = new Frm_main();
                Frm_main.Closed += (s, args) => this.Close();
                Frm_main.Show();
            }
            else
            {
                MessageBox.Show("Login Incorreto");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

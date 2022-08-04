using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CLASS_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(tbNome.Text,tbTelefone.Text);
            MessageBox.Show (cad.mensagem +" "+ tbNome.Text);
            tbNome.Text = "";
            tbTelefone.Text = "";
        }
    }
}

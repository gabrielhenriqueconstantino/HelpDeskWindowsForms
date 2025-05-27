using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class FormTecnico : Form
    {
        public FormTecnico()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

            Tecnico tecnico = new Tecnico();

            tecnico.Id = Convert.ToInt32(txtIdentificacao.Text);
            tecnico.Senha = Convert.ToInt32(txtSenha.Text);

            int Id = Convert.ToInt32(txtIdentificacao.Text);
            int Senha = Convert.ToInt32(txtSenha.Text);

            if (txtIdentificacao.Text == "" || txtIdentificacao.Text == null)
            {
                MessageBox.Show("Login do Técnico não digitada");
            }
            else if (Id > 10)
            {
                MessageBox.Show("Login do Técnico não encontrado, digite novamente!");
            }
            else if (txtSenha.Text == "" || txtSenha.Text == null)
            {
                MessageBox.Show("Senha não identificada");
            }
            else if (Senha != 123456)
            {
                MessageBox.Show("Senha do Técnico não está correto, digite novamente");
            }
            else
            {
                FormPainelDeChamados PainelChamadas = new FormPainelDeChamados();
                PainelChamadas.Show();

                this.Close();
            }
        }

        private void FormTecnico_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormCadastroUsuario : Form
    {
        private FormPainelDeChamados _painelChamados;

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        // Adicione um construtor que recebe o painel de chamados
        public FormCadastroUsuario(FormPainelDeChamados painelChamados)
        {
            InitializeComponent();
            _painelChamados = painelChamados;
        }

        public BindingList<Usuario> Usuarios = new BindingList<Usuario>();

        private async void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtNome.Text;
            usuario.Cargo = txtCargo.Text;
            usuario.Matricula = txtMaricula.Text;
            usuario.Setor = txtSetor.Text;
            usuario.Email = txtEmail.Text;

            if (txtNome.Text == "" || txtNome.Text == null)
            {
                MessageBox.Show("Usuário não digitado");
            }
            else if (txtMaricula.Text == "" || txtMaricula.Text == null)
            {
                MessageBox.Show("Matricula não informada");
            }
            else if (txtSetor.Text == "" || txtSetor.Text == null)
            {
                MessageBox.Show("Setor não informado");
            }
            else if (txtCargo.Text == "" || txtCargo.Text == null)
            {
                MessageBox.Show("Cargo não informado");
            }
            else if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                MessageBox.Show("Email não informado");
            }
            else
            {
                await Task.Delay(2000);

                // Passe a instância do painel para o próximo formulário
                FormCadastroDeMaquina AcessoMaquina = new FormCadastroDeMaquina(_painelChamados);
                AcessoMaquina.Show();

                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtMaricula.Text = null;
            txtSetor.Text = null;
            txtCargo.Text = null;
            txtEmail.Text = null;
        }
    }
}
